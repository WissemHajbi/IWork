using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IWork.Migrations
{
    /// <inheritdoc />
    public partial class JobId_ApplyModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "Applys",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "We are looking for a Business Intelligence developer in Tunis to help with the workload for our Contact Centre BI team, globally. This is an exciting opportunity for a motivated BI Developer to work, and develop, as part of a multi-disciplined team in a dynamic, fast paced, global organization. The successful candidate will have a strong analytical background, coupled with highly technical skills and should be comfortable working on their own, or as part of a larger group to deliver best in class BI tools.What you will do :\r\n                                    Responsible for the development of Reports, Dashboards & Analytics with an aim to optimise operational business performance.\r\n                                    Collaborate with stakeholders in the analysis, design, development, testing and implementation of premium BI solutions.\r\n                                    Create and automate data flows to improve the data warehouse.\r\n                                    Liaise with both technical and business colleagues located locally and in our international offices.\r\n                                    Provide recommendations to improve system functionality and processes within the BI environment.\r\n                                    Guide and assist the wider development team in leveraging best practices and delivering reusable and scalable strategic components.\r\n                                    Responsible for the development of Custom Web Applications, Dashboards & Analytics with an aim to optimise operational business performance.\r\n                                    What we need from you :\r\n                                    A rigorous, organized and analytical mind.\r\n                                    Fluent in English.\r\n                                    Expertise in SQL and at least one ETL.\r\n                                    Microsoft SQL Server, SSMS, SSRS and SSIS expertise.\r\n                                    Experience of Snowflake and Looker would be an advantage.\r\n                                    Ability to communicate findings, orally and visually, to a variety of audiences\r\n                                    Other Requirements :\r\n                                    Must be expert in Microsoft Excel.\r\n                                    Must be an effective time manager\r\n                                    Must be an effective communicator.\r\n                                    Must be passionate about Reporting and Analytics.About National Pen\r\n                                    At National Pen we strive to be the worldwide leader in providing high value promotional products for businesses and professionals by providing expert knowledge and effective promotional products. With a workforce from over 30 different countries with 18 working languages, we provide a very diverse and multi-cultural environment with on-going training to provide you with the tools to be successful.");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Field",
                value: "Technology");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 5,
                column: "Field",
                value: "Technology");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Field",
                value: "Technology");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Field",
                value: "Healthcare");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 8,
                column: "Field",
                value: "Healthcare");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 9,
                column: "Field",
                value: "Healthcare");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobId",
                table: "Applys");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "We are looking for a Business Intelligence developer in Tunis to help with the workload for our Contact Centre BI team, globally. This is an exciting opportunity for a motivated BI Developer to work, and develop, as part of a multi-disciplined team in a dynamic, fast paced, global organization. The successful candidate will have a strong analytical background, coupled with highly technical skills and should be comfortable working on their own, or as part of a larger group to deliver best in class BI tools.What you will do:\r\n\r\n                                    Responsible for the development of Reports, Dashboards & Analytics with an aim to optimise operational business performance.\r\n                                    Collaborate with stakeholders in the analysis, design, development, testing and implementation of premium BI solutions.\r\n                                    Create and automate data flows to improve the data warehouse.\r\n                                    Liaise with both technical and business colleagues located locally and in our international offices.\r\n                                    Provide recommendations to improve system functionality and processes within the BI environment.\r\n                                    Guide and assist the wider development team in leveraging best practices and delivering reusable and scalable strategic components.\r\n                                    Responsible for the development of Custom Web Applications, Dashboards & Analytics with an aim to optimise operational business performance.\r\n                                    What we need from you:\r\n\r\n                                    A rigorous, organized and analytical mind.\r\n                                    Fluent in English.\r\n                                    Expertise in SQL and at least one ETL.\r\n                                    Microsoft SQL Server, SSMS, SSRS and SSIS expertise.\r\n                                    Experience of Snowflake and Looker would be an advantage.\r\n                                    Ability to communicate findings, orally and visually, to a variety of audiences\r\n                                    Other Requirements:\r\n\r\n                                    Must be expert in Microsoft Excel.\r\n                                    Must be an effective time manager\r\n                                    Must be an effective communicator.\r\n                                    Must be passionate about Reporting and Analytics.About National Pen\r\n\r\n                                    At National Pen we strive to be the worldwide leader in providing high value promotional products for businesses and professionals by providing expert knowledge and effective promotional products. With a workforce from over 30 different countries with 18 working languages, we provide a very diverse and multi-cultural environment with on-going training to provide you with the tools to be successful.");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Field",
                value: "Computer science");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 5,
                column: "Field",
                value: "Computer science");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Field",
                value: "Computer science");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Field",
                value: "Medical");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 8,
                column: "Field",
                value: "Medical");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 9,
                column: "Field",
                value: "Medical");
        }
    }
}
