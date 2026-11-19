# Inventory Stock Management System (WinForms desktop app)

Products, suppliers, stock in/out, sales, low-stock alerts and reports.
Built from the *Inventory Stock Management System – Project Requirements Document*
using the same stack and structure as the PigPass project: Windows Forms + SQLite + MVC.

## Features (requirement IDs)
- Login by username **or email**, PBKDF2-hashed passwords (FR02, NFR02)
- Administrator creates/edits users and roles: Administrator, Stock Manager, Sales Staff (FR01, FR14)
- Products: add, edit, delete, search by name / category / code, live stock levels (FR03, FR09, FR11)
- Categories and suppliers management (FR04, FR05)
- Receive stock from suppliers; quantities update automatically (FR06, FR07)
- Record sales; a sale is **refused** when stock is insufficient (FR08, NFR07)
- Manual stock adjustments (+/-) with a mandatory reason; stock can never go negative (NFR07)
- Low-stock alert dialog at login + status-bar indicator; highlighted rows in the product list (FR10)
- Inventory, low-stock, purchase and sales reports with date range and CSV export (FR12)
- Full transaction history of purchases, sales and adjustments (FR13)
- Database backup and restore from the Administration menu (NFR09)

## Roles
| Role | Can do |
|---|---|
| Administrator | Everything, including users, backup/restore |
| Stock Manager | Products, categories, suppliers, receive stock, adjust stock, reports |
| Sales Staff | View/search products and stock levels, record sales |

## Architecture (MVC)
| Layer | Folder | Content |
|---|---|---|
| Model | `InventoryStock/Models` | User, Category, Supplier, Product, StockTransaction, row classes for grids |
| View | `InventoryStock/Views` | LoginForm, MainForm (MDI), ProductForm, CategoryForm, SupplierForm, StockForm, UserForm, ReportForm |
| Controller | `InventoryStock/Controllers` | AuthController, ProductController, CategoryController, SupplierController, StockController, ReportController, BackupController, Session |
| Data | `InventoryStock/Data` | AppDbContext (EF Core), DbSeeder |

Forms never access the database directly; they call controllers. Every stock change goes through
`StockController`, which updates the quantity and writes the transaction in one database transaction.

## How to run
1. Install Visual Studio 2022 with the ".NET desktop development" workload (.NET 8 SDK).
2. Open `InventoryStock.sln` and press F5 (NuGet packages restore automatically).
3. Log in with a demo account (database `inventory.db` is created next to the .exe on first run):

| Username | Password | Role |
|---|---|---|
| admin | admin123 | Administrator |
| manager | manager123 | Stock Manager |
| sales | sales123 | Sales Staff |

## Technologies
C#, .NET 8, Windows Forms, Entity Framework Core 8, SQLite
