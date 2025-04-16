# Pizza Store: Web API & Vue Frontend

## Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- [Node.js & npm](https://nodejs.org/)
- [SQLite](https://www.sqlite.org/) (optional, for DB inspection)

---

## Project Structure

- `PizzaStoreApi/` — ASP.NET Core Web API (.NET 9, EF Core, SQLite)
- `pizza-frontend/` — Vue.js 3 frontend (Vite, TypeScript)

---

## Backend Setup (`PizzaStoreApi`)

1. **Install dependencies:**
   ```sh
   cd PizzaStoreApi
   dotnet restore
   ```

2. **Apply EF Core migrations (creates/updates the SQLite DB):**
   ```sh
   dotnet ef database update
   ```

3. **Run the API:**
   ```sh
   dotnet run
   ```
   The API will start (default: `https://localhost:5001` or `http://localhost:5000`).

4. **Swagger UI:**
   - Visit `/swagger` in your browser (e.g., `https://localhost:5001/swagger`) to explore the API.

---

## Entity Framework Core Migration Workflow

- **Add a new migration:**
  ```sh
  dotnet ef migrations add <MigrationName>
  ```
- **Apply migrations to the database:**
  ```sh
  dotnet ef database update
  ```
- **Remove last migration (if needed):**
  ```sh
  dotnet ef migrations remove
  ```

> Make sure you have the `Microsoft.EntityFrameworkCore.Design` package installed for migration commands.

---

## Frontend Setup (`pizza-frontend`)

1. **Install dependencies:**
   ```sh
   cd pizza-frontend
   npm install
   ```

2. **Run the development server:**
   ```sh
   npm run dev
   ```
   The app will be available at `http://localhost:5173` (or as shown in the terminal).

---

## Environment Variables

- Backend: See `PizzaStoreApi/appsettings.json` and `appsettings.Development.json`
- Frontend: Create a `.env` file in `pizza-frontend/` if you need to override API URLs, etc.

---

## Notes

- The SQLite database file is `PizzaStoreApi/pizzas.db`.
- Update CORS settings in the API if accessing from a different frontend origin.

---

## Git & .gitignore

- The repository includes a `.gitignore` that covers Node, .NET, editor, and OS artifacts.
- Do not commit sensitive files like `.env` or `appsettings.Development.json`.
