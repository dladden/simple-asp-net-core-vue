# Simple ASP.NET and Vue Project

This project consists of an ASP.NET Core backend (found in the ApplicationApi directory) and a Vue.js frontend powered by Vite (found in the vite-client directory). The Goal of this project is to test vue running through ASP.NET core to see how fast this application performs.

### Getting Started:

#### Prerequisites

- .NET SDK (for the ASP.NET Core backend)
- Node.js & npm (for the Vue.js frontend)
  Running the ASP.NET Core Backend
- Navigate to the ApplicationApi directory:

`cd ApplicationApi`

`dotnet restore`

`dotnet run`

The API should now be running and typically will be accessible at http://localhost:5000.
Running the Vue.js Frontend

#### Navigate to the vite-client directory:

`cd vite-client`

`npm install`

`npm run dev`

The front-end should now be running and typically will be accessible at http://localhost:3000 or another port if Vite is configured differently.
Why Vite?
Vite offers faster and more efficient development for modern web projects. Some benefits include:

- Lightning Fast HMR: Vite provides extremely fast Hot Module Replacement (HMR), which updates modules in the browser as they are edited without a full page reload.
- Rich Features Out-of-the-Box: Features like ES modules, CSS code splitting, and optimized builds are provided without additional configuration.
- Flexible Build System: While Vite is optimized for Vue.js projects, it supports various frameworks, making it adaptable and future-proof.
- Simplified Tooling: Vite aims to reduce the complexity of modern frontend tooling, streamlining the development process.
  Given these advantages, Vite is an excellent choice for developing the Vue.js frontend of this project, ensuring rapid development and efficient production builds.
