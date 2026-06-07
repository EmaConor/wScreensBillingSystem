# wScreensBillingSystem

Sistema de facturacion de escritorio para Windows Forms que permite gestionar clientes, productos, empleados, facturas y seguridad de usuarios. Construido con una arquitectura de 3 capas usando .NET 9 (UI) y .NET Framework 4.7.2 (logica de negocio y acceso a datos).

---

## Caracteristicas

- Gestion de clientes (CRUD con busqueda)
- Gestion de productos con categorias (CRUD con busqueda)
- Gestion de empleados con roles (CRUD)
- Gestion de roles (CRUD)
- Creacion de facturas y seguimiento de estados (Pendiente Pago, Pagada, Anulada, Vencida)
- Autenticacion de usuarios y gestion de credenciales de seguridad
- Visor de reportes
- Navegador de ayuda integrado mediante WebView2
- Interfaz Material Design con MaterialSkin.2

---

## Tecnologias

| Capa | Tecnologia |
|---|---|
| UI / Presentacion | .NET 9.0-windows, Windows Forms, MaterialSkin.2, WebView2 |
| Logica de Negocio | .NET Framework 4.7.2 (Biblioteca de clases) |
| Acceso a Datos | .NET Framework 4.7.2 (Biblioteca de clases), ADO.NET (Microsoft.Data.SqlClient) |
| Base de Datos | SQL Server (Express o LocalDB) |

---

## Estructura del Proyecto

```
wBillingLayersProject.sln
│
├── Data_Access_Layer/            .NET Framework 4.7.2
│   └── DataAccess.cs             Conexion a BD y ejecucion de comandos
│
├── wBusinessLogicLayer/          .NET Framework 4.7.2
│   ├── Customer.cs               Logica de clientes
│   ├── Product.cs                Logica de productos
│   ├── Category.cs               Logica de categorias
│   ├── Employee.cs               Logica de empleados
│   ├── Rol.cs                    Logica de roles
│   ├── Security.cs               Logica de seguridad
│   └── ValidateUser.cs           Validacion de inicio de sesion
│
├── wScreensBillingSystem/        .NET 9.0-windows (WinForms)
│   ├── FrmLogin.cs               Formulario de inicio de sesion
│   ├── FrmMain.cs                Contenedor principal con MaterialSkin
│   ├── FrmCustomers.cs           Listado de clientes
│   ├── FrmCustomerModal.cs       Agregar/Editar cliente
│   ├── FrmProducts.cs            Listado de productos
│   ├── FrmProductModal.cs        Agregar/Editar producto
│   ├── FrmCategories.cs          Listado de categorias
│   ├── FrmCategoryModal.cs       Agregar/Editar categoria
│   ├── FrmEmployees.cs           Listado de empleados
│   ├── FrmRols.cs                Listado de roles
│   ├── FrmInvoices.cs            Listado de facturas
│   ├── FrmInvoiceModal.cs        Creacion de facturas
│   ├── FrmSecurity.cs            Gestion de credenciales de seguridad
│   ├── FrmReport.cs              Visor de reportes
│   ├── FrmHelp.cs                Navegador de ayuda (WebView2)
│   ├── FrmAbout.cs               Acerca de
│   └── images/                   13 iconos PNG
│
├── wScreensBillingSystem_Installer/  Proyecto de instalador de Visual Studio
├── images/                           Imagenes adicionales
└── Script base de datos_dbFacturas.sql  Script de creacion de base de datos
```

---

## Requisitos Previos

- Visual Studio 2022 o superior
- .NET 9 SDK
- Paquete de destino .NET Framework 4.7.2 (incluido con Visual Studio)
- SQL Server (se recomienda Express, instancia `SQLEXPRESS`)
- SQL Server Management Studio (recomendado para configurar la base de datos)

---

## Guia de Instalacion

### 1. Clonar el repositorio

```bash
git clone <url-del-repositorio>
cd wScreensBillingSystem
```

### 2. Abrir la solucion

Abra `wBillingLayersProject.sln` en Visual Studio.

### 3. Restaurar paquetes NuGet

Haga clic derecho en la solucion en el Explorador de Soluciones y seleccione **Restaurar paquetes NuGet**.

La solucion usa tanto `packages.config` (para proyectos .NET Framework 4.7.2) como `PackageReference` (para el proyecto .NET 9). Ambos se restauraran automaticamente.

### 4. Configurar la base de datos

Tiene dos opciones para crear la base de datos:

#### Opcion A: Ejecutar el script SQL (recomendado)

Abra `Script base de datos_dbFacturas.sql` en SQL Server Management Studio y ejecutelo. Esto creara:

- La base de datos `DBFACTURAS`
- Todas las tablas (TBLCATEGORIA_PROD, TBLCLIENTES, TBLEMPLEADO, TBLROLES, TBLSEGURIDAD, TBLPRODUCTO, TBLFACTURA, TBLDETALLE_FACTURA, TBLESTADO_FACTURA)
- Datos de prueba (categorias, clientes, empleados, roles, estados y usuarios)
- El procedimiento almacenado `SpConsultaFactura`

#### Opcion B: Restaurar la copia de seguridad

Usando SQL Server Management Studio, restaure el archivo `BACKUP_BD_FACTURAS.BAK` como la base de datos `DBFACTURAS`.

### 5. Configurar la cadena de conexion

La cadena de conexion a la base de datos esta actualmente hardcodeada en `Data_Access_Layer/DataAccess.cs` (linea 22):

```csharp
connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog = [DBFACTURAS]; Integrated Security = True;TrustServerCertificate = True;");
```

Si su instancia de SQL Server tiene un nombre diferente (por ejemplo, `localhost`, `.\SQLEXPRESS` o una instancia nombrada), edite esta linea segun corresponda.

### 6. Establecer el proyecto de inicio

En Visual Studio, haga clic derecho en el proyecto `wScreensBillingSystem` en el Explorador de Soluciones y seleccione **Establecer como proyecto de inicio**.

### 7. Compilar y ejecutar

Presione `F5` o haga clic en **Depurar > Iniciar depuracion**. Aparecera el formulario de inicio de sesion.

---

## Credenciales por Defecto

| Usuario | Contrasena |
|---|---|
| admin | 1234 |
| rosmi | asdf |
| pepe | 123 |

---

## Resumen de la Base de Datos

La base de datos `DBFACTURAS` contiene las siguientes tablas:

| Tabla | Descripcion |
|---|---|
| TBLCATEGORIA_PROD | Categorias de productos |
| TBLCLIENTES | Clientes |
| TBLEMPLEADO | Empleados (vinculados a roles) |
| TBLROLES | Roles de empleados (Gerente, Secretaria, Operario, Administrativo) |
| TBLSEGURIDAD | Credenciales de inicio de sesion (vinculadas a empleados) |
| TBLPRODUCTO | Productos (vinculados a categorias) |
| TBLFACTURA | Facturas (vinculadas a clientes, empleados y estados) |
| TBLDETALLE_FACTURA | Detalle de facturas (vinculado a facturas y productos) |
| TBLESTADO_FACTURA | Estados de factura (Pendiente Pago, Pagada, Anulada, Vencida) |

---

## Mejoras Futuras

- **Prevencion de SQL Injection**: Migrar todas las consultas a comandos parametrizados o procedimientos almacenados.
- **Hash de contrasenas**: Implementar almacenamiento seguro usando bcrypt o algoritmo similar.
- **Control de acceso por roles**: Restringir acceso a ciertas funciones segun el rol del empleado.
- **Manejo de sesion**: Rastrear el usuario autenticado y mantener el estado de sesion en toda la aplicacion.
- **Cadena de conexion configurable**: Mover la connection string del codigo fuente a `app.config`.
- **Manejo de excepciones**: No exponer detalles de excepciones al usuario final; implementar logging adecuado.
- **Modulo de facturacion**: Completar la funcionalidad de creacion de facturas y reportes.

---

## Leer en ingles

[README.md](README.md) -- Read in English
