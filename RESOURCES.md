# Resources and code provenance

Use one section at a time, tied to a concrete exercise. Reading every linked page is not an assignment.

## Starting references

These Microsoft references were read during planning on November 4, 2026. Recheck version-sensitive setup instructions on the desktop before use.

| Resource | When to use it |
| --- | --- |
| [C# for Java developers](https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tips-for-java-developers) | Sessions 1–2: familiar ideas and C# differences |
| [C# language tour](https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/overview) | Look up only the feature in the current exercise |
| [ASP.NET Core MVC movie tutorial](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-10.0) | Small app structure and controller/view flow |
| [Model and EF Core section](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-10.0) | Models, database context and persistence |
| [MVC search section](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/search?view=aspnetcore-10.0) | Read a LINQ query and existing search behavior |
| [.NET support policy](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core) | Confirm supported versions before setup |

The planning default is .NET 10, an active LTS release at the November 4 check. Keep the SDK, packages and selected tutorial version consistent. Microsoft pages may include multiple version sections. The tutorial links to sample code, but that GitHub directory was not successfully fetched during planning; no downloaded sample has been verified or run for this kit.

## Imported code register

No external code imported. Session 1 uses [an AI-generated training starter](exercises/session-01/Program.cs), created November 8, 2026, targeting net10.0 with no external package dependencies. It is not a Microsoft sample. Build/run evidence is recorded in PROGRESS.md; the exercise must not be executed before Ted's prediction.

## Reading record

- November 8, 2026: assigned only the opening paragraph and first example of [The foreach statement](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement), followed by the Session 1 prediction. Source checked today. Ted has not yet reported reading it; comprehension is not assessed.

## Desktop setup source checks — November 8, 2026

- [Official .NET support policy](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core): .NET 10 listed as active LTS. Chosen target: net10.0, stable SDK only.
- [Microsoft installation-script reference](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-install-script): recommends installers for development environments. Used the Microsoft.DotNet.SDK.10 WinGet package rather than a script-based SDK installation. Exact resolved SDK and outcome are in PROGRESS.md.
- No MVC tutorial setup or EF Core/SQLite package selection performed; recheck matching versions when Session 3 begins.

### Reading update — November 8, 2026, Session 2 opening

Ted reports reading part of the loop article before Session 1; exact section and full completion unspecified. Prefers short excerpts followed by code practice.

## Session 2 code provenance

November 8, 2026: exercises/session-02 targets net10.0 without external packages. AI generated the console harness and Movie class, integrating Ted's FindCheapest attempts and correction with the assistance documented in LEARNING LOG.md. Not an imported Microsoft sample. Normal example run verified; edge cases pending prediction/check.
