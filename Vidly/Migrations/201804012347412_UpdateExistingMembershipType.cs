namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateExistingMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET MembershipName ='Pay as You Go' WHERE DurationInMonths = 0");
            Sql("UPDATE MembershipTypes SET MembershipName ='Monthly' WHERE DurationInMonths = 1");
            Sql("UPDATE MembershipTypes SET MembershipName ='Quarterly' WHERE DurationInMonths = 3");
            Sql("UPDATE MembershipTypes SET MembershipName ='Annual' WHERE DurationInMonths = 12");

        }

        public override void Down()
        {
        }
    }
}
