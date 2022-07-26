﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CityInfo.Api.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "The one with that big park.", "New York City" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "The one with the cathedral that was never really finished.", "Antwerp" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "The one with that big tower.", "Paris" });

            migrationBuilder.InsertData(
                table: "PointsOfInterest",
                columns: new[] { "id", "CityId", "Description", "Name" },
                values: new object[] { 1, 1, "The most visited urban park in the United States.", "Central Park" });

            migrationBuilder.InsertData(
                table: "PointsOfInterest",
                columns: new[] { "id", "CityId", "Description", "Name" },
                values: new object[] { 2, 1, "A 102-story skyscrapper located in MidTown Manhattan.", "Empire State Building" });

            migrationBuilder.InsertData(
                table: "PointsOfInterest",
                columns: new[] { "id", "CityId", "Description", "Name" },
                values: new object[] { 3, 2, "The gothic-style cathedral,conceived by architects..", "Cathedral" });

            migrationBuilder.InsertData(
                table: "PointsOfInterest",
                columns: new[] { "id", "CityId", "Description", "Name" },
                values: new object[] { 4, 2, "The finest example of railway architecture in Belgium.", "Antwerp Central Station" });

            migrationBuilder.InsertData(
                table: "PointsOfInterest",
                columns: new[] { "id", "CityId", "Description", "Name" },
                values: new object[] { 5, 3, "a wrought iron lattice tower on the champ de Mars,named Eiffel tower.", "Eiffel tower" });

            migrationBuilder.InsertData(
                table: "PointsOfInterest",
                columns: new[] { "id", "CityId", "Description", "Name" },
                values: new object[] { 6, 3, "The world's largest museum.", "The Louvre" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PointsOfInterest",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PointsOfInterest",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PointsOfInterest",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PointsOfInterest",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PointsOfInterest",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PointsOfInterest",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
