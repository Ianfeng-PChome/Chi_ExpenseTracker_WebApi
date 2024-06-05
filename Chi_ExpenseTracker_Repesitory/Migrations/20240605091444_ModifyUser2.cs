﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chi_ExpenseTracker_Repesitory.Migrations
{
    /// <inheritdoc />
    public partial class ModifyUser2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "User",
                type: "datetime",
                nullable: false,
                defaultValueSql: " GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2024, 6, 5, 17, 9, 37, 735, DateTimeKind.Local).AddTicks(6701));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "User",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 5, 17, 9, 37, 735, DateTimeKind.Local).AddTicks(6701),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: " GETDATE()");
        }
    }
}
