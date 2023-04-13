using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.SoftPOS.Migrations
{
    /// <inheritdoc />
    public partial class Created_Segments_entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppPosTerminal",
                columns: table => new
                {
                    Terminal_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RetailerData_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardSchema_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageText_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicKey_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerminalConnection_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeviceSpecific_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AIDList_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AIDData_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RevokeCertificates_ID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppPosTerminal", x => x.Terminal_ID);
                });

            migrationBuilder.CreateTable(
                name: "AppCategory",
                columns: table => new
                {
                    Category_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Terminal_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Segment_ID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCategory", x => x.Category_ID);
                    table.ForeignKey(
                        name: "FK_AppCategory_AppPosTerminal_Terminal_ID",
                        column: x => x.Terminal_ID,
                        principalTable: "AppPosTerminal",
                        principalColumn: "Terminal_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppAD_Seg01",
                columns: table => new
                {
                    Segment_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Category_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AIDLabel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerminalAIDVersionNumbers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExactOnlySelection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkipEMVProcessing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultTDOL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultDDOL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMVAdditionalTags = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DenialActionCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OnlineActionCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultActionCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThresholdValueForBaisedRandomSelection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TargetPercentage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxTargetPercentageForBasiedRandomSelection = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAD_Seg01", x => x.Segment_ID);
                    table.ForeignKey(
                        name: "FK_AppAD_Seg01_AppCategory_Category_ID",
                        column: x => x.Category_ID,
                        principalTable: "AppCategory",
                        principalColumn: "Category_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppAL_Seg01",
                columns: table => new
                {
                    Segment_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Category_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AID01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AID02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AID03 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AID04 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AID05 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AID06 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AID07 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AID08 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AID09 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AID010 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAL_Seg01", x => x.Segment_ID);
                    table.ForeignKey(
                        name: "FK_AppAL_Seg01_AppCategory_Category_ID",
                        column: x => x.Category_ID,
                        principalTable: "AppCategory",
                        principalColumn: "Category_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppCS_Seg01",
                columns: table => new
                {
                    Segment_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Category_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CardSchemeID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardSchemeNameArabic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardSchemeNameEnglish = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardSchemeAcquirerID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MerchantCategoryCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MerchantID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerminalID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnableEMV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckServiceCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OfflineRefundAuthorization = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCS_Seg01", x => x.Segment_ID);
                    table.ForeignKey(
                        name: "FK_AppCS_Seg01_AppCategory_Category_ID",
                        column: x => x.Category_ID,
                        principalTable: "AppCategory",
                        principalColumn: "Category_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppCS_Seg02",
                columns: table => new
                {
                    Segment_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Category_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CardSchemeID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionsAllowed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardholderAuthentication = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupervisorFunctions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManualEntryAllowed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FloorlimitIndicator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerminalFloorLimit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerminalFloorLimitFallBack = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxCashBack = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxTransactionAmountIndicator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxAmountAllowed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LuhnCheck = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiryDatePosition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DelayCallSetUp = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCS_Seg02", x => x.Segment_ID);
                    table.ForeignKey(
                        name: "FK_AppCS_Seg02_AppCategory_Category_ID",
                        column: x => x.Category_ID,
                        principalTable: "AppCategory",
                        principalColumn: "Category_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppCS_Seg03",
                columns: table => new
                {
                    Segment_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Category_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CardSchemeID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardRanges = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardPrefixSequenceIndicator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCS_Seg03", x => x.Segment_ID);
                    table.ForeignKey(
                        name: "FK_AppCS_Seg03_AppCategory_Category_ID",
                        column: x => x.Category_ID,
                        principalTable: "AppCategory",
                        principalColumn: "Category_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppDS_Seg01",
                columns: table => new
                {
                    Segment_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Category_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardScheme01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerminalContactlessTransactionLimit01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerminalCVMRequiredLimit01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerminalContactlessFloorLimit01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardScheme02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerminalContactlessTransactionLimit02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerminalCVMRequiredLimit02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerminalContactlessFloorLimit02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardScheme03 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerminalContactlessTransactionLimit03 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerminalCVMRequiredLimit03 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerminalContactlessFloorLimit03 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxSAFCumualtiveAmount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdleTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxReconciliationAmount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxTransactionsProcessed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QRCodePrintIndicator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppDS_Seg01", x => x.Segment_ID);
                    table.ForeignKey(
                        name: "FK_AppDS_Seg01_AppCategory_Category_ID",
                        column: x => x.Category_ID,
                        principalTable: "AppCategory",
                        principalColumn: "Category_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppMT_Seg01",
                columns: table => new
                {
                    Segment_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Category_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MessageCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageTextArabic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageTextEnglish = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppMT_Seg01", x => x.Segment_ID);
                    table.ForeignKey(
                        name: "FK_AppMT_Seg01_AppCategory_Category_ID",
                        column: x => x.Category_ID,
                        principalTable: "AppCategory",
                        principalColumn: "Category_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppPK_Seg01",
                columns: table => new
                {
                    Segment_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Category_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KeyIndex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HashID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DigitalSignatureID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Exponent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckSum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CAPublicKeyLength = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CAPublicKeyExpiryDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppPK_Seg01", x => x.Segment_ID);
                    table.ForeignKey(
                        name: "FK_AppPK_Seg01_AppCategory_Category_ID",
                        column: x => x.Category_ID,
                        principalTable: "AppCategory",
                        principalColumn: "Category_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppRC_Seg01",
                columns: table => new
                {
                    Segment_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Category_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDX = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CertSerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRC_Seg01", x => x.Segment_ID);
                    table.ForeignKey(
                        name: "FK_AppRC_Seg01_AppCategory_Category_ID",
                        column: x => x.Category_ID,
                        principalTable: "AppCategory",
                        principalColumn: "Category_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppRD_Seg01",
                columns: table => new
                {
                    Segment_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Category_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NextLoad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReconciliationTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageIndicator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerminalCurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerminalCountryCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionCurrencyExponent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrencySymbolArabic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrencySymbolEnglish = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiptArabic01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiptArabic02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiptEnglish01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiptEnglish02 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRD_Seg01", x => x.Segment_ID);
                    table.ForeignKey(
                        name: "FK_AppRD_Seg01_AppCategory_Category_ID",
                        column: x => x.Category_ID,
                        principalTable: "AppCategory",
                        principalColumn: "Category_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppRD_Seg02",
                columns: table => new
                {
                    Segment_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Category_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AddressArabic01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressEnglish01 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRD_Seg02", x => x.Segment_ID);
                    table.ForeignKey(
                        name: "FK_AppRD_Seg02_AppCategory_Category_ID",
                        column: x => x.Category_ID,
                        principalTable: "AppCategory",
                        principalColumn: "Category_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppRD_Seg03",
                columns: table => new
                {
                    Segment_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Category_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AddressArabic02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressEnglish02 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRD_Seg03", x => x.Segment_ID);
                    table.ForeignKey(
                        name: "FK_AppRD_Seg03_AppCategory_Category_ID",
                        column: x => x.Category_ID,
                        principalTable: "AppCategory",
                        principalColumn: "Category_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppRD_Seg04",
                columns: table => new
                {
                    Segment_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Category_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TerminalCapability = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalTerminalCapability = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DownloadPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMVTerminalType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutomicLoad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SAFRetryLimit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SAFDefaultMessageTransmissionNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRD_Seg04", x => x.Segment_ID);
                    table.ForeignKey(
                        name: "FK_AppRD_Seg04_AppCategory_Category_ID",
                        column: x => x.Category_ID,
                        principalTable: "AppCategory",
                        principalColumn: "Category_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppTC_Seg01",
                columns: table => new
                {
                    Segment_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Category_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommunicationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTimeout = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DialAttemptToPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConnectTimeForPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaudRate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParityRate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataRate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StopRate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NetworkIPAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NetworkTCPport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SSLCertificateFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountAccessRetries = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GPRSDialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GPRSAccessPointName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConnectTimeForGPRSPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DialAttemptsToNetwork = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppTC_Seg01", x => x.Segment_ID);
                    table.ForeignKey(
                        name: "FK_AppTC_Seg01_AppCategory_Category_ID",
                        column: x => x.Category_ID,
                        principalTable: "AppCategory",
                        principalColumn: "Category_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppAD_Seg01_Category_ID",
                table: "AppAD_Seg01",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppAL_Seg01_Category_ID",
                table: "AppAL_Seg01",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppCategory_Terminal_ID",
                table: "AppCategory",
                column: "Terminal_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppCS_Seg01_Category_ID",
                table: "AppCS_Seg01",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppCS_Seg02_Category_ID",
                table: "AppCS_Seg02",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppCS_Seg03_Category_ID",
                table: "AppCS_Seg03",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppDS_Seg01_Category_ID",
                table: "AppDS_Seg01",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppMT_Seg01_Category_ID",
                table: "AppMT_Seg01",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppPK_Seg01_Category_ID",
                table: "AppPK_Seg01",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppRC_Seg01_Category_ID",
                table: "AppRC_Seg01",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppRD_Seg01_Category_ID",
                table: "AppRD_Seg01",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppRD_Seg02_Category_ID",
                table: "AppRD_Seg02",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppRD_Seg03_Category_ID",
                table: "AppRD_Seg03",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppRD_Seg04_Category_ID",
                table: "AppRD_Seg04",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppTC_Seg01_Category_ID",
                table: "AppTC_Seg01",
                column: "Category_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppAD_Seg01");

            migrationBuilder.DropTable(
                name: "AppAL_Seg01");

            migrationBuilder.DropTable(
                name: "AppCS_Seg01");

            migrationBuilder.DropTable(
                name: "AppCS_Seg02");

            migrationBuilder.DropTable(
                name: "AppCS_Seg03");

            migrationBuilder.DropTable(
                name: "AppDS_Seg01");

            migrationBuilder.DropTable(
                name: "AppMT_Seg01");

            migrationBuilder.DropTable(
                name: "AppPK_Seg01");

            migrationBuilder.DropTable(
                name: "AppRC_Seg01");

            migrationBuilder.DropTable(
                name: "AppRD_Seg01");

            migrationBuilder.DropTable(
                name: "AppRD_Seg02");

            migrationBuilder.DropTable(
                name: "AppRD_Seg03");

            migrationBuilder.DropTable(
                name: "AppRD_Seg04");

            migrationBuilder.DropTable(
                name: "AppTC_Seg01");

            migrationBuilder.DropTable(
                name: "AppCategory");

            migrationBuilder.DropTable(
                name: "AppPosTerminal");
        }
    }
}
