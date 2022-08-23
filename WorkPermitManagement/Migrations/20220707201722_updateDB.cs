using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkPermitManagement.Migrations
{
    public partial class updateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NaturalAdvantage",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "activity",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "address",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "employer",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "function",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "nationality",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "otherAdavantages",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "passportNumber",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "salaryInNumbers",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "salaryInWords",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "socialSecurityNumber",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "taxIdNumber",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "userName",
                table: "WorkPermit");

            migrationBuilder.AddColumn<string>(
                name: "CODE_AVANT",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CODE_CONT",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CODE_DEM",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CODE_REGIME",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONT_ACTIVITE",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONT_ACTIVITE_L",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "CONT_CARTE_SEJOUR",
                table: "WorkPermit",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "CONT_CAT_ENT",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONT_CODE_ACT",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONT_CODE_CAS_SOC",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONT_CODE_CONTRAT",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONT_CODE_DELEG",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONT_CODE_ENT",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CONT_CODE_PERS",
                table: "WorkPermit",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CONT_CODE_SIT_MAT",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONT_CREATED_BY",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CONT_DATE_DEBUT",
                table: "WorkPermit",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CONT_DATE_ENVOI_DR",
                table: "WorkPermit",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CONT_DATE_FIN",
                table: "WorkPermit",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CONT_DATE_PAIE",
                table: "WorkPermit",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CONT_DATE_RESILIATION",
                table: "WorkPermit",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CONT_DATE_SAISIE",
                table: "WorkPermit",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CONT_EMPLOYEUR",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONT_EMPLOYEUR_ADR",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONT_EMPLOYEUR_ADR_L",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONT_EMPLOYEUR_L",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "CONT_EST_RESILIE",
                table: "WorkPermit",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<int>(
                name: "CONT_ETAT_PAIE",
                table: "WorkPermit",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CONT_FONCTION",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONT_FONCTION_L",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CONT_MODE_PAIE",
                table: "WorkPermit",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CONT_NATIONALITE",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONT_NATIONALITE_L",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CONT_NATURE_CONTRAT",
                table: "WorkPermit",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CONT_NUM_CNSS",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONT_OBS",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONT_PASSEPORT",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONT_PERSONNE",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONT_PERSONNE_L",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONT_QRCODE_AR",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONT_QRCODE_FR",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONT_REF_PAIE",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CONT_SALAIRE",
                table: "WorkPermit",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "CONT_SIGNER",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONT_SIGNER_L",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CONT_UPDATE",
                table: "WorkPermit",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CONT_UPDATED_BY",
                table: "WorkPermit",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CONT_VAL_LOGEMENT",
                table: "WorkPermit",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "CONT_VAL_NOURRITURE",
                table: "WorkPermit",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_LIVRAISON",
                table: "WorkPermit",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "synched",
                table: "WorkPermit",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CODE_AVANT",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CODE_CONT",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CODE_DEM",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CODE_REGIME",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_ACTIVITE",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_ACTIVITE_L",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_CARTE_SEJOUR",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_CAT_ENT",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_CODE_ACT",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_CODE_CAS_SOC",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_CODE_CONTRAT",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_CODE_DELEG",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_CODE_ENT",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_CODE_PERS",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_CODE_SIT_MAT",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_CREATED_BY",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_DATE_DEBUT",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_DATE_ENVOI_DR",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_DATE_FIN",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_DATE_PAIE",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_DATE_RESILIATION",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_DATE_SAISIE",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_EMPLOYEUR",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_EMPLOYEUR_ADR",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_EMPLOYEUR_ADR_L",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_EMPLOYEUR_L",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_EST_RESILIE",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_ETAT_PAIE",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_FONCTION",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_FONCTION_L",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_MODE_PAIE",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_NATIONALITE",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_NATIONALITE_L",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_NATURE_CONTRAT",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_NUM_CNSS",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_OBS",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_PASSEPORT",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_PERSONNE",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_PERSONNE_L",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_QRCODE_AR",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_QRCODE_FR",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_REF_PAIE",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_SALAIRE",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_SIGNER",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_SIGNER_L",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_UPDATE",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_UPDATED_BY",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_VAL_LOGEMENT",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "CONT_VAL_NOURRITURE",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "DATE_LIVRAISON",
                table: "WorkPermit");

            migrationBuilder.DropColumn(
                name: "synched",
                table: "WorkPermit");

            migrationBuilder.AddColumn<string>(
                name: "NaturalAdvantage",
                table: "WorkPermit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "activity",
                table: "WorkPermit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "WorkPermit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "employer",
                table: "WorkPermit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "function",
                table: "WorkPermit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nationality",
                table: "WorkPermit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "otherAdavantages",
                table: "WorkPermit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "passportNumber",
                table: "WorkPermit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "salaryInNumbers",
                table: "WorkPermit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "salaryInWords",
                table: "WorkPermit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "socialSecurityNumber",
                table: "WorkPermit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "taxIdNumber",
                table: "WorkPermit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "userName",
                table: "WorkPermit",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
