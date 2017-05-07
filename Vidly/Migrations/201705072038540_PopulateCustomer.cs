namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomer : DbMigration
    {
        public override void Up()
        {

            Sql("Insert into MembershipTypes(Id, SignupFee, DurationInMonths, DiscountRate) Values(1,7,1,0)");
            Sql("Insert into MembershipTypes(Id,SignupFee, DurationInMonths, DiscountRate) Values(2,15,3,10)");
            Sql("Insert into MembershipTypes(Id, SignupFee, DurationInMonths, DiscountRate) Values(3,20,6,20)");
            Sql("Insert into MembershipTypes(Id, SignupFee, DurationInMonths, DiscountRate) Values(4,60,12,20)");

        }
        
        public override void Down()
        {
        }
    }
}
