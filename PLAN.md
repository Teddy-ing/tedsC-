# First eight sessions

Accepted direction: a C# refresher, early ASP.NET MVC practice, reading existing code and small AI-assisted changes. Pace: 4–5 hours/week, approximately two weeks. Adjust using actual exercises. Session 1 checkpoint completed November 8, 2026, with assistance recorded in LEARNING LOG.md; Session 2 is next.

## Week 1 — language and a request through the app

### Session 1: find the starting point

Inspect tools and create only a tiny console exercise if needed. Present a 20–30-line movie-list example with a class, properties, a method and a loop. Ask Ted to predict behavior before running it. Then let him change a price condition and test an empty list and an exact boundary. Separate unfamiliar syntax from unclear concepts. Use documentation freely and record assistance.

Checkpoint: Ted can explain the condition and attempt a related change. If fundamentals are difficult, Session 2 refreshes those specific ideas. If they are comfortable, proceed faster. Setup taking the session is a valid outcome.

### Session 2: C# differences through small changes

Begin with a variation on Session 1. Practice properties, method parameters, List<T> and nullable values through short examples. Consult the Java comparison guide. Compare a loop to Where/lambda syntax only when the loop is understood. Do not turn the entire language tour into homework.

Checkpoint: explain one C# feature and make a small modification with recorded assistance. Record what still needs help.

### Session 3: follow an ASP.NET MVC request

Prepare or import a small runnable movie app using compatible SDK and package versions. Prefer the official Microsoft tutorial/sample. A complete small sample is acceptable; Ted does not have to type every scaffolded file. Record its provenance and verify the baseline. Follow one URL through routing, a controller action and a Razor view. Ask Ted to locate code, predict one result and make a small visible change. Introduce Program.cs and constructor injection only as needed.

Checkpoint: locate the action handling a URL and explain how data reaches the page. Build/run success is setup evidence, not Ted's proficiency.

### Session 4: a form and a debugging session

Trace a create/edit form from input through model binding, controller validation, save and response. Use a breakpoint or logs to inspect one value. Work with one invalid input and a correction. Keep database internals for the next session when possible.

Checkpoint: explain where submitted data arrives and what happens on invalid input; demonstrate a focused change. Take a short week-one review and adjust the remaining plan if needed.

## Week 2 — data, verification and a ticket

### Session 5: queries in context

Read the app's model and EF Core database context. Follow one LINQ query, its execution and its async result. Teach Task/await through that example, without introducing all concurrency concepts. Have Ted write a simple SELECT/WHERE equivalent and personally change a small query. Explain that a C# in-memory collection and a database-backed query are different execution contexts.

Checkpoint: explain where the data is stored, which condition filters it and when results are retrieved. Record provider/version issues instead of spending the whole lesson chasing them.

### Session 6: validation and checking behavior

Have Ted add or adjust one small validation rule distinct from the ticket below. Inspect attributes and nullable values in that context. Verify normal input, invalid input and a boundary. Add a small behavior-focused automated check if it helps; Codex can prepare the test harness. Preserve the difference between UI-only checks and server-side validation.

Checkpoint: reproduce a failure, explain the chosen check, and verify the correction. Merely seeing a green test is insufficient without understanding its assertion.

### Session 7: a narrow task in an established app

Use the ticket below against a baseline with existing movie list, create/edit, title/genre search and validation. If adapting another imported codebase, choose an equivalent small task and record the change in scope. Ted first locates the relevant files and proposes behavior. Use hints and AI implementation help as needed. Review a focused diff together. Keep this exercise small enough to pause cleanly.

Checkpoint: describe the request flow and the purpose of each changed file; record what Ted wrote, what AI generated and what was verified.

### Session 8: revisit, debug and explain

Begin without reading the previous solution. Ask Ted to explain the feature, then give one small variation or deliberately introduced bug in a preserved practice copy. Check behavior and discuss the result. Review evidence across the sessions and choose the next week's emphasis together.

Checkpoint: apply at least one idea to a new case. Record unresolved gaps without assigning a global proficiency score. Two weeks does not establish job readiness.

## Training ticket: optional maximum price

Add an optional maximum-price filter to the movie list, preserving existing title/genre search.

Acceptance criteria:

- Blank maximum leaves the current search behavior unchanged.
- A valid maximum includes movies at or below that value, including the exact boundary.
- Price and existing search filters combine correctly.
- No matches produces a normal empty result.
- Invalid or negative input produces a useful validation error without crashing.
- Entered search/filter values remain visible so the user can understand the result.

Start by locating the action, query and view. Do not provide the completed patch in the task brief. Discuss optional input, filtering and validation through the code. Run checks against the actual database provider; do not assume all LINQ expressions behave identically across providers. No unrelated redesign or database migration is required unless the chosen baseline actually needs it.

## How to scale the plan

Repeat a difficult session with a smaller example. Combine easy material only after a demonstration. Count reading and setup toward the time budget. If the imported app is too complex, select a smaller slice or switch to the small teaching app. Keep the first route focused on MVC; additional APIs, SQL joins, deployment and a larger unfamiliar repository can follow when useful.

## Pace adjustment — November 8, 2026, Session 2

Ted requests harder code-reading and reasoning challenges because elementary drills feel too easy. Increase difficulty adaptively using actual attempts; explain unfamiliar C# syntax up front so syntax novelty is distinct from conceptual difficulty. Cover useful C# differences after diagnosing gaps, then proceed to ASP.NET Core MVC. The session outline remains flexible; do not require repetitive basic drills solely to fill it.
