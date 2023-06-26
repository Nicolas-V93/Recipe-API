<div id="top"></div>


<!-- PROJECT LOGO -->
<br />
<div>
<h3>Recipe API</h3>
  <p>
    A .NET REST API built according to clean architecture.
    <br>
    Authentication and Authorization handled by Microsoft Identity with the aid of JWT tokens.
    <br>
    Data is stored in a SQL database.
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
    </li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

This API allows registered users to add their own recipes.
Users can also review other user's recipes.

Authorization includes resource-based authorization.
- Users cannot review their own recipes.
- Users cannot delete recipes from other users.

Admins have full access

<br />


<p align="right">(<a href="#top">back to top</a>)</p>


<!-- GETTING STARTED -->
## Getting Started

**Requirements:**
- [SQL Server Express](https://www.microsoft.com/nl-be/sql-server/sql-server-downloads?raw=true) 
- [SQL Server Management Studio](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16?raw=true)

1. Clone the repository 
 ```sh
   git clone https://github.com/Nicolas-V93/Recipe-API.git
   ```
2. In appsettings.development.json, change connectionstring accordingly.
3. Execute ```dotnet ef migrations <TITLE>```
5. Execute ```dotnet ef database update```

<p align="right">(<a href="#top">back to top</a>)</p>
