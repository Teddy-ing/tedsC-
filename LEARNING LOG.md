# Learning log

This starter kit was prepared November 8, 2026; creating it is not evidence of C# practice. Actual setup and learning entries follow below.

Append actual entries below, using America/Los_Angeles dates. Keep them short. Mark outside reading and results as user-reported when not directly observed. Do not turn proposed actions into completed work.

## Entry template — not a completed session

### YYYY-MM-DD — Session N: topic

- Time: reported/observed estimate, or not recorded.
- Task and evidence: file/method, resource section or specific question.
- Ted's attempt/explanation: concise description of what he actually did.
- Assistance: documentation, hints, worked example or AI implementation; distinguish each.
- Checks and outcome: exact behavior or command observed; state unrun checks separately.
- Unresolved point: specific gap or question, or none observed.
- Revisit: one small retrieval task for a later session.
- Resume: exact next action; update PROGRESS.md to match.

## Actual sessions

### 2026-11-08 — Session 1: desktop setup and first prediction assigned

- Time: Ted allocated about one hour including setup; actual elapsed study time not recorded. Session still in progress.
- Setup evidence: Windows x64 10.0.26200 / 25H2; Git 2.54.0; Antigravity 2.24.0.0 found, editor integration untested. No SDK found initially. Installed Microsoft .NET SDK 10.0.403 through WinGet after Ted reported approving the Windows permission prompt; installation success and SDK listing observed.
- Assistance: AI generated only the 26-line [console starter](exercises/session-01/Program.cs), project file and instructions. No external packages, MVC app, Git initialization or learner condition change. Official support/installation references checked; see RESOURCES.md.
- Checks: starter build passed with 0 warnings/0 errors. Initial sandbox build failed on SDK first-use access; approved elevated build succeeded. Exercise output, empty-list behavior and boundary behavior have not been run or verified.
- Reading/task: opening paragraph and first example of Microsoft's foreach section assigned; predict titles/order and exact-maximum behavior in `PrintAffordable`. Reading not yet reported complete.
- Ted's attempt: none yet. No language skills assessed and no misconception established. Installation approval is setup evidence only.
- Revisit: later trace a different maximum with the old solution closed; not yet assessed.
- Resume: wait for Ted's first prediction, discuss it, then run/check before assigning the small price-condition change.

### 2026-11-08 — Session 1: first prediction checked

- Time: same session; elapsed study time not recorded.
- Ted's explanation: identified List<Movie>, Movie objects, readable/writable Title and Price properties, method arguments, foreach iteration and the price comparison. Predicted only Moon and correctly excluded Arrival because equality is not included by `<`.
- Assistance: earlier short syntax notes and assigned foreach reading; reading completion not explicitly reported. AI confirmed the prediction and strict comparison meaning after Ted answered. No worked solution or code edit supplied.
- Checks: `dotnet run` failed on sandbox access to an SDK first-use sentinel. Executing the already-built Session01.dll succeeded (exit 0), printing Moon. No modified-condition or empty-list test yet.
- Evidence: reading/tracing demonstrated once on this starter with prior syntax notes; independent modification remains unassessed.
- Unresolved point: Ted reports rusty comparison-operator recall and occasional confusion with conditions/loops; this explanation was correct, so no specific loop misconception established.
- Revisit: trace a different maximum with the old solution closed.
- Resume: Ted supplies just a replacement `if` line that includes the exact maximum; leave Program.cs unchanged until his attempt.

### 2026-11-08 — Session 1: inclusive comparison checked

- Time: same session; elapsed study time not recorded.
- Ted's attempt: supplied `if (movie.Price <= maximum)` in chat, then predicted Moon followed by Arrival and no other titles.
- Assistance: AI previously explained that adding an equals sign includes equality, then confirmed the supplied operator. AI applied Ted's exact line in Program.cs; original condition `<` remains recorded in prior entries. No independent editor work claimed.
- Checks: dotnet run rebuilt/executed the modified starter, printing Moon then Arrival, exit 0. Used process-only telemetry opt-out and ASP.NET certificate-generation flags; no elevation needed this time. Existing data checks below (8), equal (10) and above (12) maximum 10.
- Evidence: inclusive condition practiced with help; prediction correct before execution. No later retention claim.
- Unresolved point: operator recall warrants later retrieval; empty-list behavior not assessed or run yet.
- Revisit: compare strict/inclusive boundaries with different values and the old solution closed.
- Resume: ask what prints and how many loop-body executions occur for an empty list; wait for Ted before changing data/running.

### 2026-11-08 — Session 1: loop visits versus printed output

- Time: same session; elapsed study time not recorded.
- Ted's attempt: correctly predicted no empty-list output; initially guessed one loop visit, then tentatively self-corrected to no visits because there is no object. After explanation, correctly predicted one visit and no output for one movie at 12 with maximum 10.
- Assistance: AI explained that foreach checks for an available item before entering the body; the if is not evaluated for an empty list. Follow-up contrast was prompted by AI.
- Checks: AI made a temporary copy with a stderr marker for each loop visit. Empty list: zero markers/no titles; one excluded item: one marker/no titles. Both builds passed with zero warnings/errors and executions exited 0. Learner source remained unchanged; workspace temporary copy removed after checks.
- Setup issue: first temporary-directory build failed on sandbox access; workspace temporary-copy builds succeeded. Failed attempt is not counted as behavior evidence.
- Evidence: loop/condition distinction practiced with help; correct immediate follow-up, not a later retention check.
- Revisit: count visits and output separately for an empty list and one excluded item with this explanation closed.
- Resume: Ted supplies just the revised PrintAffordable call for a maximum of 8; wait before applying or running.

### 2026-11-08 — Session 1: changing a method argument

- Time: same session; elapsed study time not recorded.
- Ted's attempt: supplied `PrintAffordable(movies, 8m);` for the requested maximum, then predicted only Moon before execution.
- Assistance: AI requested a call-site change, confirmed that the second argument supplies maximum, then applied Ted's exact line. No replacement line was provided before Ted's attempt; independent editor use remains unassessed.
- Checks: dotnet run rebuilt/executed the current project and printed Moon, exit 0. Source now uses maximum 8m with Ted's <= condition; original list prices remain 8, 10, 12.
- Evidence: supplying an argument and predicting this boundary demonstrated once in chat; not a later retention check.
- Unresolved point: whether Ted distinguishes comparing with a parameter from changing stored properties has not yet been assessed.
- Revisit: trace another maximum with the old example closed; distinguish visits from printed output.
- Resume: ask whether the call changes Movie.Price values or only printed results, and why; wait for explanation.

### 2026-11-08 — Session 1: comparison versus changing data

- Time: same session; elapsed study time not recorded.
- Ted's explanation: passing 8m supplies maximum for the comparison; no stored Price changes because the function never assigns one. Identified that changing a property would require setting it, while expressing uncertainty about C# syntax.
- Assistance: AI confirmed the explanation and clarified that the function also receives the movie list. Next explanation supplies ordinary property assignment syntax; no mutation implemented.
- Evidence: comparison versus mutation demonstrated once in his own explanation. Setter syntax is a specific syntax gap, not evidence of confusion about mutation itself.
- Checks: none newly run; Program.cs remains the three original movies, <= condition, maximum 8m. Last observed output: Moon.
- Checkpoint: Session 1 core reading/change/boundary/empty-list work covered with assistance recorded. Session still open; no elapsed-time or retention claim.
- Revisit: strict versus inclusive comparison and loop visits versus output with the previous explanation closed.
- Resume: predict titles for a hypothetical `movie.Price = maximum;` inside foreach before the if, with maximum 8m. Wait before editing/running.

### 2026-11-08 — Session 1: assignment prediction and decimal suffix

- Time: same session; elapsed study time not recorded.
- Ted's prediction: Moon, Arrival, Dune for the hypothetical assignment before the if; explained that each object's price becomes maximum and therefore passes the inclusive comparison.
- Assistance: AI had shown property assignment syntax and the hypothetical loop fragment. Ted explained the result before any execution; AI confirmed it.
- Question: Ted asked why decimal literals contain m when the property/parameter already has decimal type; this is a newly identified syntax question.
- Explanation supplied: m/M marks a decimal literal, is not part of the numeric value or a currency marker; compare 8 (int), 8.0 (double), 8m/8.0m (decimal), and distinguish a literal's type from its destination type. Comprehension not yet checked.
- Checks: no new execution; hypothetical mutation not applied. Actual file and last verified output remain maximum 8m with only Moon printed.
- Revisit: strict/inclusive comparison and loop visits without prior solution; later check literal suffix understanding in real code.
- Resume: answer the suffix question; no new exercise assigned. If Ted continues, use a small hands-on edit; if stopping, resume Session 2 with the queued retrieval.

### 2026-11-08 — Session 1 extension: first complete function attempt

- Time: same session; elapsed study time not recorded. Ted asked what comes next; AI proposed a small writing task before Session 2.
- Task: write PrintTitles to print all titles regardless of price. AI supplied the signature and empty body; referring to the existing function was explicitly allowed.
- Ted's exact attempt (preserved below):

```csharp
static void PrintTitles(List<Movie> movies)
{
    foreach (Movie movie in movies)
    {
        
            Console.WriteLine(movie.Title);
        
    }
}
```

- Assistance/evidence: correct loop and print statement supplied by Ted, with no intervening hint or correction. Demonstrated once with the signature supplied and reference available; not evidence of unaided recall or independent editor use.
- Review: function is correct on inspection; extra whitespace is harmless. No execution or source-file edit yet. Actual Program.cs still contains only PrintAffordable and its existing call.
- Revisit: write a small loop from a fresh signature with the previous solution closed.
- Resume: ask Ted for the single call line using the existing movies list, then discuss predicted output before integrating/running his code.

### 2026-11-08 — Session 1 checkpoint: PrintTitles verified

- Time: elapsed study time not recorded; natural stopping point reached after Session 1 core tasks and writing extension.
- Ted's attempt: first supplied `PrintAffordable(movies);`; after AI pointed out the name/parameter mismatch, corrected to `PrintTitles(movies);`. Ted described the first response as careless; no broader misconception inferred. Then correctly predicted Moon, Arrival, Dune in order.
- Assistance: AI integrated Ted's function body with whitespace normalized and his corrected call. Exact original function attempt preserved in the prior entry. Old PrintAffordable remains for comparison.
- Checks: dotnet run printed Moon, Arrival, Dune, exit 0. Compiler warning CS8321 reports that retained PrintAffordable is unused; no runtime failure. No claim of a warning-free current build.
- Evidence: correct function body with supplied signature/reference available, correct output prediction, call correction with a hint. Independent editor work and later retention remain unassessed.
- Checkpoint: Session 1 objectives met with assistance recorded. Specific review topics: comparison operators, loop visits versus output, decimal suffix, and matching calls to function signatures.
- Revisit/resume: begin Session 2 with one small variation and the old solution closed, then practice parameters/properties through Ted's own edit. No Session 2 code generated yet.

### 2026-11-08 — Session 2: opening retrieval

- Time: default roughly 60 minutes; elapsed study time not recorded.
- Ted reports reading part of the loop article before Session 1. Exact section/completion unspecified. Short reading followed by code felt better than broad language-guide reading, which he stopped from boredom.
- Preference: documentation is welcome; keep excerpts focused and connected to guided code practice.
- Task: chat-only example with Cedar at 6m, Harbor at 9m, maximum 9m and strict <. Predict loop visits/output and supply an inclusive condition, old solution closed.
- Assistance/checks: AI supplies example; no answer or execution supplied. Retrieval pending; no new skill evidence yet.
- Resume: wait for prediction, discuss/check, then practice parameters/properties through a small edit.

### 2026-11-08 — Session 2: immediate recall discussed

- Time: Ted reports continuing directly from Session 1, with the prior exercise about two minutes earlier; no measured study duration.
- Attempt: correctly stated two loop visits, Cedar-only output, and that less-than-or-equal includes both. His explanation included the ambiguous phrase "because it has the same value as Harbor."
- Assistance: AI clarified Cedar is 6 below maximum 9, while Harbor equals maximum 9. No broader misconception inferred from that phrase.
- Evidence: correct immediate prediction and operator choice; not a spaced retention check. No code executed for this chat example.
- Next task: supplied signature SetPrice(Movie movie, decimal newPrice); Ted writes its body in chat. Earlier property-assignment example remains prior assistance; no new solution supplied.
- Revisit: strict/inclusive boundaries and loop visits in a later session after a gap. Resume with Ted's SetPrice attempt.

### 2026-11-08 — Session 2: property assignment and pace adjustment

- Time: not recorded; continuing directly from earlier work.
- Ted supplied the SetPrice body verbally as movie dot price equals newPrice. AI rendered movie.Price = newPrice; with capitalization/semicolon. Prior session had shown assignment syntax; independent editor use not assessed.
- Ted predicted both values as "five M" for SetPrice(movie, price) with price 5m. Numeric values correct; AI clarified that m is a source literal suffix and is not printed. No execution performed.
- Ted says basic drills feel too easy and requests increasing code-reading/reasoning difficulty until meaningful gaps emerge, while explaining unfamiliar C# syntax rather than treating it as a conceptual failure.
- Context: Ted reports having regained code-reading fluency quickly during a Python internship, including reading senior developers' code. Recorded as self-report, not assessed proficiency.
- Adjustment: use a more substantial trace involving repeated object references, mutation, and a changing local parameter; then useful C# features and ASP.NET Core MVC. AI supplies syntax/collection clarification before prediction; no answer supplied.
- Resume: wait for ApplyDiscount trace. Revisit decimal output and reference/value behavior later; no new successful execution claimed.

### 2026-11-08 — Session 2: shared-reference trace

- Time: not recorded. Ted traced the changing amount, correctly obtaining first price 6 and second price 7.
- Attempt: uncertain whether repeated first entries share an object or are independent; proposed third output 6 if shared, 4 if independent. Correctly predicted caller discount remains 2 because only amount changes.
- Assistance: AI had stated that list entries store references, not copies. After the attempt, AI confirmed shared identity and output Moon: 6, Arrival: 7, Moon: 6, Discount: 2, and explains the third condition fails at price 6. Also clarify >= includes equality; Ted verbally called it greater than seven.
- Evidence: multi-step mutation/parameter trace demonstrated once with supplied code; object aliasing remains uncertain and is practiced with explanation. No program execution performed; outcomes checked by inspection only.
- Next task: replace third list entry with a new Movie having the same initial values; predict output and whether that visit changes first. No solution supplied for variation.
- Revisit: distinguish shared reference, separate object and decimal parameter copy on a later check.

### 2026-11-08 — Session 2: object identity and reassignment

- Time: not recorded. All exercises in this entry were chat-only; no execution or source edit.
- Ted correctly predicted prices 6, 7, 4 when the third movie was separately constructed. Fourth discount output not supplied in that answer; AI confirmed it remained 2.
- For ChangeMovie(first), Ted initially predicted Arrival: 3 after the parameter was reassigned. AI explained copied references versus shared objects and supplied a reference diagram and worked result Moon: 6.
- Ted then correctly explained that removing the initial Price assignment leaves Moon at 8: later mutation affects the replacement. AI refined properties versus parameters and same-object reference terminology.
- On the next supplied list example, Ted correctly explained replacing movies[0] does not change first and predicted Moon: 8, Arrival: 3, Moon: 8. Numeric/identity reasoning correct; m continued in verbal answers, so output-format recall not established.
- Evidence: reference semantics practiced with help; correct immediate transfer after explanation, not later retention. Ted intends to verbalize alternative interpretations so uncertainty is visible.
- Resume: trace a method that mutates a list entry, then reassigns its List parameter. Revisit reference-copy versus object mutation after a gap.

### 2026-11-08 — Session 2: FindCheapest attempts and prediction

- Time: not recorded. Earlier list-parameter trace initially confused replacing an entry with overwriting first; after a diagram Ted correctly explained Moon remained reachable via first and could be added back to the list. Practiced with help, not retained evidence.
- Task: FindCheapest returns the first cheapest movie at or below maximum, or null. Ted proposed a running cheapest price initialized to 100 and a candidate object; independently questioned the arbitrary sentinel and return placement.
- Assistance: AI explained return after the loop, nullable candidate initialized to null, using the candidate's Price instead of duplicate state, strict comparison for ties, and syntax fixes. Supplied outer-loop skeleton and prompted candidate conditions.
- Ted reasoned through the null-candidate and cheaper-candidate cases, then wrote nested conditions with reversed assignments. After an assignment-direction hint, he corrected both to lowest = movie. AI integrates these contributions with capitalization, punctuation and formatting corrected; no independent editor work claimed.
- Prediction: correctly traced Moon 12 skipped at maximum 10, Arrival 8 selected, Dune 8 retained as a tie without replacement, Alien 6 selected last. Final candidate Alien. This is explanation evidence separate from execution.
- Original attempts preserved below. Session 2 harness and Movie class are AI-generated; Session 1 unchanged. Runtime result recorded in the following entry.
- Revisit: candidate initialization, assignment direction and first-on-tie behavior after a gap. Next: predict empty-list and no-qualifying-movie cases before checking them.

First attempt, verbatim code:

```csharp
static Movie? FindCheapest(List<Movie> movies, decimal maximum)
{
	int currentcheapest =100; 
    Movie lowest;
    foreach (Movie movie in movies)
	{
	if (movie.price <= maximum && movie.price <= currentcheapest{
         lowest = movie;
currentcheapest = movie.price}
	}
return lowest
}
```

Second attempt, verbatim code:

```csharp
Movie? lowest = null;

foreach (Movie movie in movies)
{
    if (movie.Price <= maximum)
    {
        if (lowest == null) { movie = lowest} else if (movie.price < lowest.price) { movie = lowest}
    }
}

return lowest;
```

### 2026-11-08 — Session 2: FindCheapest example verified

- AI assembled Ted's corrected method and a minimal console harness in exercises/session-02/Program.cs, targeting net10.0 with no external packages.
- Check: dotnet run --project .\exercises\session-02\Session02.csproj using the documented full SDK path and process-only flags printed Alien: 6, exit 0; no warnings shown.
- Result matches Ted's final candidate prediction. Harness prints only the final candidate; intermediate candidate states were explained by Ted, not instrumented during execution.
- Empty-list, no-match, isolated tie and exact-boundary checks not yet run.
- Resume: ask return values for an empty list and existing list with maximum 5m before checking. Actual study time not recorded.

### 2026-11-08 — Session 2: empty and no-match cases checked

- Time: not recorded.
- Ted independently predicted null in both cases and explained zero foreach visits for an empty list versus four visits with no passing price condition at maximum 5m. Clarified return lowest returns its unchanged null value.
- Assistance: no new hint before prediction; earlier nullable-candidate scaffolding remains prior help.
- AI checked a temporary copy of the same method with an empty list and with the original four movies at maximum 5m. Both printed No qualifying movie; command exited 0, no warnings shown. Source method unchanged; temporary copy removed.
- Evidence: correct edge-case explanations before execution, demonstrated once within this session; not later retention.
- Resume: predict Arrival 8m followed by Dune 8m at maximum 8m to isolate tie and exact-boundary behavior, then check.

### 2026-11-08 — Session 2: tie/boundary checkpoint verified

- Time: not recorded.
- Ted correctly predicted Arrival at maximum 8 for Arrival 8 followed by Dune 8; explained inclusive maximum, initial null selection, and strict comparison preserving Arrival on the tie.
- No new hint before this prediction. AI ran a temporary copy with that input: Arrival: 8, exit 0, no warnings shown; temporary copy removed, learner source unchanged.
- FindCheapest checkpoint covered with recorded help: normal result, empty input, no match, exact maximum and first-on-tie. Correct explanations and runtime outcomes recorded separately; no independent editor or retention claim.
- Next: explain || and left-to-right short-circuit evaluation; Ted supplies a combined inner candidate condition. Do not apply the refactor before his attempt.
- Later revisit: candidate initialization and reference semantics with old solutions closed. MVC remains the next planned session; no app setup begun.

### 2026-11-08 — Session 2: short-circuit refactor

- Time: not recorded.
- After AI explained || and left-to-right short-circuit evaluation, Ted supplied the correct combined condition: lowest == null || movie.Price < lowest.Price, retaining lowest = movie inside it and the outer maximum check.
- Assistance: AI supplied the syntax concept and skeleton, then applied Ted's exact condition; previous two-branch attempt remains preserved above. No replacement condition given before Ted's attempt.
- Evidence: combined condition written correctly once with explanation immediately available. Understanding of why order matters remains to be checked.
- Next question: would reversing the two operands be safe on the first qualifying movie, and why? No reversed code applied.
- Refactor check: Session02 dotnet run printed Alien: 6, exit 0, no warnings shown. Edge cases previously checked on two-branch version; not rerun. Original predicted example preserved.

### 2026-11-08 — Session 2: short-circuit clarification and checkpoint

- Time: not recorded; no session-end assumed.
- Ted initially expected reversed condition order to work when lowest was null. AI explained that reading null.Price throws before the right operand can be checked.
- Follow-up discussion was ambiguous because AI switched between original and reversed expressions. Ted explicitly clarified which ordering he had been considering, then correctly explained that false on the left requires checking the right, whereas true skips it.
- Evidence: short-circuit behavior practiced with explanation; final explanation correct with actual expression visible. Do not infer an ongoing misconception from the ambiguous follow-up or claim later retention.
- Session 2 checkpoint met with help: property assignment, reference identity/reassignment, nullable candidate, loop selection, boundary/tie handling, and ||. Program and observed checks documented above.
- Ted requests whether another exercise level is worthwhile and an overview of the first four units. Recommend MVC next, with optional brief LINQ comparison; no new reading or exercise assigned yet.
- Revisit after a gap: candidate initialization, reference reassignment and safe null-check ordering. Next substantial work: Session 3 runnable MVC baseline and request trace.
