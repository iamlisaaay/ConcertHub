# ConcertHub — Event Ticketing & Band Analytics Platform

An interactive full-stack web application designed for concert discovery, ticket reservation, and dynamic performance visualization. The project emphasizes intuitive UI/UX workflows, responsive Razor-based components, and interactive data visualization.

---

## Frontend Highlights & UI/UX

* **Interactive Data Dashboards:** Visualized group activity, concert metrics, and booking statistics using **Chart.js** with asynchronous data fetching.
* **Responsive Layouts & Components:** Clean, accessible multi-page layout built with semantic HTML5, modern CSS3, and Razor Views.
* **Dynamic Modals & Controls:** Interactive elements for venue selection, concert filtering, and ticket count calculations.

---

## Key Application Features

* **Event Catalog & Filtering:** Browse upcoming concerts, view artists/bands lineup, and explore venue capacity in real time.
* **User Accounts & Profiles:** Secure authentication, profile management, and custom avatar customization.
* **Community Feedback:** Public reviews and comments on concert event pages.
* **Admin Tools:** Excel-based bulk import and export services for concert catalogues.

---

## Tech Stack

* **Frontend:** JavaScript (ES6+), Chart.js, HTML5, CSS3, Razor Views, Bootstrap / Custom CSS
* **Backend:** C#, .NET, ASP.NET Core MVC
* **Database & ORM:** PostgreSQL, Entity Framework Core (Code-First)
* **Architecture:** MVC Pattern, Factory Pattern (Import/Export DataPort services)

---

## Project Architecture

* **Frontend Views (`Views/`):**
  * `Groups/ActivityChart.cshtml` — dynamic Chart.js reporting interface
  * `Concerts/` & `Tickets/` — event catalog, ticket booking flows, and detailed venue information
  * `Account/` — authentication views, password reset, and profile management
* **Controllers & Services (`Controllers/`, `Services/`):**
  * Handlers for business logic, async database queries, authentication flow, and data import/export pipelines.

---

## Getting Started

### Prerequisites
* [.NET 8.0 SDK](https://dotnet.microsoft.com/download)
* [PostgreSQL](https://www.postgresql.org/)


---

## 📸 Screenshots

![Dashboard Screenshot]<img width="1917" height="1078" alt="Снимок экрана 2026-09-17 163416" src="https://github.com/user-attachments/assets/08424f42-bdf8-42c9-8cb0-a80c6e913086" />
<img width="1917" height="1078" alt="Снимок экрана 2026-09-17 163409" src="https://github.com/user-attachments/assets/3abbd861-0035-4da7-8e00-a99949ee9e21" />
<img width="1917" height="1078" alt="Снимок экрана 2026-09-17 163344" src="https://github.com/user-attachments/assets/38656064-4415-421d-ba35-a2ccd8efcd06" />
<img width="1917" height="1078" alt="Снимок экрана 2026-09-17 163337" src="https://github.com/user-attachments/assets/08c01b31-3a6d-4d9e-b93e-95257b7e5a55" />

### Quick Run

1. **Clone the repository:**
   ```bash
   git clone [https://github.com/](https://github.com/)<your-username>/ConcertHub.git
   cd ConcertHub/WebApplication1
