namespace DotvvmApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Enrollments", "CourseID", "dbo.Courses");
            DropForeignKey("dbo.Enrollments", "StudentID", "dbo.Students");
            DropIndex("dbo.Enrollments", new[] { "CourseID" });
            DropIndex("dbo.Enrollments", new[] { "StudentID" });
            DropTable("dbo.Courses");
            DropTable("dbo.Enrollments");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        EnrollmentID = c.Int(nullable: false, identity: true),
                        CourseID = c.Int(nullable: false),
                        StudentID = c.Int(nullable: false),
                        Grade = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.EnrollmentID);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Credits = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseID);
            
            CreateIndex("dbo.Enrollments", "StudentID");
            CreateIndex("dbo.Enrollments", "CourseID");
            AddForeignKey("dbo.Enrollments", "StudentID", "dbo.Students", "StudentID", cascadeDelete: true);
            AddForeignKey("dbo.Enrollments", "CourseID", "dbo.Courses", "CourseID", cascadeDelete: true);
        }
    }
}
