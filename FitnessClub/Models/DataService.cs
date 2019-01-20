using System;
using System.Data.Objects;
using System.Linq;
using FitnessClub.Tools;

namespace FitnessClub.Models
{
    class DataService
    {
        #region member
        public Member[] GetMembers(String filter)
        {
            var db = new FitnessClubEntities();
            var members =
                (db.Member.Select(member => new { member, loweredFilter = filter.ToLower() }).Select(
                    @t => new { @t, firstName = @t.member.FirstName, lastname = @t.member.LastName }).Where(
                        @t => (String.IsNullOrEmpty(@t.@t.loweredFilter) ||
                               (@t.firstName.StartsWith(@t.@t.loweredFilter)) ||
                                (@t.lastname.StartsWith(@t.@t.loweredFilter)))).OrderBy(@t => @t.firstName).Select(@t => @t.@t.member));

            var result = db.LoadAndInclude<Member>(members, "Abonnement");

            return Detach(db, result.ToArray());
        }

        public void InsertMember(Member member)
        {
            var db = new FitnessClubEntities();
            if (member.FirstName != null | member.LastName != null)
            {
                var t = member.MemberId = db.Member.NextId(f => f.MemberId);
                db.AddToMember(member);
                db.SaveChanges();
            }

        }

        public void UpdateMember(Member member)
        {
            var db = new FitnessClubEntities();
            db.Attach(member);
            member.SetAllModified(db);
            db.SaveChanges();
            db.Detach(member);
        }

        public void DeleteMember(Member member)
        {
            var db = new FitnessClubEntities();
            db.AttachTo("Member", member);
            db.DeleteObject(member);
            db.SaveChanges();
        }
        #endregion

        #region Abonnement
        public Abonnement[] GetAbonnements(int memberId)
        {
            var db = new FitnessClubEntities();

            var abonnements = db.Abonnement.Where(o => o.Member.MemberId == memberId).OrderBy(p=>p.DateInscription);

            //var result = db.LoadAndInclude<Abonnement>(abonnements, "Member");

            return Detach(db, abonnements.ToArray());
        }

        public void InsertAbonnement(int memberId, Abonnement abonnement)
        {
            var db = new FitnessClubEntities();

            if (abonnement.DateInscription != null)
            {
                abonnement.AbonnementId = db.Abonnement.NextId(f => f.AbonnementId);
                abonnement.Member = db.Member.Where(n => n.MemberId == memberId).FirstOrDefault();

                db.AddToAbonnement(abonnement);
                db.SaveChanges();
            }

        }

        public void UpdateAbonnement(Abonnement abonnement)
        {
            var db = new FitnessClubEntities();

            db.Attach(abonnement);
            abonnement.SetAllModified(db);
            db.SaveChanges();
        }

        public void DeleteAbonnement(Abonnement abonnement)
        {
            var db = new FitnessClubEntities();

            db.AttachTo("Abonnement", abonnement);
            db.DeleteObject(abonnement);
            db.SaveChanges();
        }
        #endregion

        #region Detach
        private T[] Detach<T>(ObjectContext context, T[] objects)
        {
            foreach (T o in objects)
                context.Detach(o);

            return objects;
        }
        #endregion
    }
}
