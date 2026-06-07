# wScreensBillingSystem

A Windows Forms desktop billing and invoicing system for managing customers, products, employees, invoices, and user security. Built with a 3-layer architecture using .NET 9 (UI) and .NET Framework 4.7.2 (business logic and data access layers).

---

## Features

- Customer management (CRUD with search)
- Product management with categories (CRUD with search)
- Employee management with roles (CRUD)
- Role management (CRUD)
- Invoice creation and status tracking (Pending Payment, Paid, Cancelled, Overdue)
- User authentication and security credential management
- Report viewer
- Built-in help browser via WebView2
- Material Design UI using MaterialSkin.2

---

## Tech Stack

| Layer | Technology |
|---|---|
| UI / Presentation | .NET 9.0-windows, Windows Forms, MaterialSkin.2, WebView2 |
| Business Logic | .NET Framework 4.7.2 Class Library |
| Data Access | .NET Framework 4.7.2 Class Library, ADO.NET (Microsoft.Data.SqlClient) |
| Database | SQL Server (Express or LocalDB) |

---

## Project Structure

```
wBillingLayersProject.sln
│
├── Data_Access_Layer/            .NET Framework 4.7.2
│   └── DataAccess.cs             Database connection and command execution
│
├── wBusinessLogicLayer/          .NET Framework 4.7.2
│   ├── Customer.cs               Customer business logic
│   ├── Product.cs                Product business logic
│   ├── Category.cs               Category business logic
│   ├── Employee.cs               Employee business logic
│   ├── Rol.cs                    Role business logic
│   ├── Security.cs               User security logic
│   └── ValidateUser.cs           Login validation
│
├── wScreensBillingSystem/        .NET 9.0-windows (WinForms)
│   ├── FrmLogin.cs               Login form
│   ├── FrmMain.cs                Main container with MaterialSkin
│   ├── FrmCustomers.cs           Customer list
│   ├── FrmCustomerModal.cs       Add/Edit customer
│   ├── FrmProducts.cs            Product list
│   ├── FrmProductModal.cs        Add/Edit product
│   ├── FrmCategories.cs          Category list
│   ├── FrmCategoryModal.cs       Add/Edit category
│   ├── FrmEmployees.cs           Employee list
│   ├── FrmRols.cs                Role list
│   ├── FrmInvoices.cs            Invoice list
│   ├── FrmInvoiceModal.cs        Invoice creation
│   ├── FrmSecurity.cs            Security credential management
│   ├── FrmReport.cs              Report viewer
│   ├── FrmHelp.cs                Help browser (WebView2)
│   ├── FrmAbout.cs               About dialog
│   └── images/                   13 PNG icons
│
├── wScreensBillingSystem_Installer/  Visual Studio Installer project
├── images/                           Additional images
└── Script base de datos_dbFacturas.sql  Database creation script
```

---

## Prerequisites

- Visual Studio 2022 or later
- .NET 9 SDK
- .NET Framework 4.7.2 targeting pack (included with Visual Studio)
- SQL Server (Express edition recommended, instance name `SQLEXPRESS`)
- SQL Server Management Studio (recommended for database setup)

---

## Getting Started

### 1. Clone the repository

```bash
git clone <repository-url>
cd wScreensBillingSystem
```

### 2. Open the solution

Open `wBillingLayersProject.sln` in Visual Studio.

### 3. Restore NuGet packages

Right-click the solution in Solution Explorer and select **Restore NuGet Packages**.

The solution uses both `packages.config` (for the .NET Framework 4.7.2 projects) and `PackageReference` (for the .NET 9 project). Both will be restored automatically.

### 4. Database setup

You have two options to create the database:

#### Option A: Run the SQL script (recommended)

Open `Script base de datos_dbFacturas.sql` in SQL Server Management Studio and execute it. This will:

- Create the `DBFACTURAS` database
- Create all tables (TBLCATEGORIA_PROD, TBLCLIENTES, TBLEMPLEADO, TBLROLES, TBLSEGURIDAD, TBLPRODUCTO, TBLFACTURA, TBLDETALLE_FACTURA, TBLESTADO_FACTURA)
- Insert seed data (categories, customers, employees, roles, statuses, and user accounts)
- Create the `SpConsultaFactura` stored procedure

#### Option B: Restore the database backup

Using SQL Server Management Studio, restore the `BACKUP_BD_FACTURAS.BAK` file as the `DBFACTURAS` database.

### 5. Configure the connection string

The database connection string is currently hardcoded in `Data_Access_Layer/DataAccess.cs` (line 22):

```csharp
connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog = [DBFACTURAS]; Integrated Security = True;TrustServerCertificate = True;");
```

If your SQL Server instance has a different name (e.g., `localhost`, `.\SQLEXPRESS`, or a named instance), edit this line accordingly.

### 6. Set the startup project

In Visual Studio, right-click the `wScreensBillingSystem` project in Solution Explorer and select **Set as Startup Project**.

### 7. Build and run

Press `F5` or click **Debug > Start Debugging**. The login form will appear.

---

## Default Credentials

| Username | Password |
|---|---|
| admin | 1234 |
| rosmi | asdf |
| pepe | 123 |

---

## Database Overview

The `DBFACTURAS` database contains the following tables:

| Table | Description |
|---|---|
| TBLCATEGORIA_PROD | Product categories |
| TBLCLIENTES | Customers |
| TBLEMPLEADO | Employees (linked to roles) |
| TBLROLES | Employee roles (Manager, Secretary, Operator, Administrative) |
| TBLSEGURIDAD | Login credentials (linked to employees) |
| TBLPRODUCTO | Products (linked to categories) |
| TBLFACTURA | Invoices (linked to customers, employees, and statuses) |
| TBLDETALLE_FACTURA | Invoice line items (linked to invoices and products) |
| TBLESTADO_FACTURA | Invoice statuses (Pending Payment, Paid, Cancelled, Overdue) |

---

## Future Improvements

- **SQL Injection prevention**: Migrate all queries to parameterized commands or a stored procedure-based approach.
- **Password hashing**: Implement secure password storage using bcrypt or a similar hashing algorithm.
- **Role-based access control**: Restrict access to certain features based on employee roles.
- **Session management**: Track the authenticated user and maintain session state throughout the application.
- **Connection string configuration**: Move the connection string from source code to `app.config`.
- **Exception handling**: Avoid exposing exception details to end users; implement proper logging instead.
- **Invoice module**: Complete the invoice creation and reporting functionality.

---

## Read on

[README.es.md](README.es.md) -- Leer en espanol
