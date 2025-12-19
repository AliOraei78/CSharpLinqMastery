# C# LINQ Mastery Showcase

A console application demonstrating comprehensive LINQ skills on a 100,000-record dataset.

## LINQ Basics

- **Method Syntax** – Chainable extension methods (`Where`, `OrderBy`, `Select`, `Take`).
- **Query Syntax** – SQL-like syntax using `from`, `where`, `orderby`, `select`.
- 10 basic queries implemented in both syntaxes (identical results).

## Deferred vs Immediate Execution

### Key Concepts
- **Deferred Execution** – Query is defined but not executed until enumeration (e.g., `foreach`, `Count()`, `ToList()`).
- **Immediate Execution** – Operators like `ToList()`, `ToArray()`, `Count()`, `First()` force immediate execution.

### Demonstration
- Deferred query re-executes on each enumeration → reflects data changes.
- Immediate query executes once → result is fixed, unaffected by later data modifications.
- Tested with heavy `GroupBy` query and data modification after query definition.

### Impact
- Deferred: useful for live data, but multiple enumerations can be expensive.
- Immediate: better for caching results or when data shouldn't change.

## Complex LINQ Queries

- 10 advanced queries on 100k dataset:
  - GroupBy with aggregation (average salary per city)
  - Inner Join with Department data
  - SelectMany, Any, All, Aggregate, Distinct, SkipWhile/TakeWhile, Zip
- Real-world scenarios demonstrated.

## Bad LINQ Queries & Anti-Patterns

- **N+1 Problem** – Separate query per item (slow database calls in real apps).
- **Cartesian Product** – Join without proper condition (explosive result set).
- **Premature ToList()** – Forces immediate execution, high memory usage.

Common pitfalls in large datasets – demonstrated with timing and memory measurements.

## LINQ Optimization & Benchmark

- BenchmarkDotNet results: significant improvements in time and memory.

| Method                | Mean          | Error         | StdDev        | Gen0      | Gen1      | Gen2     | Allocated   |
|---------------------- |--------------:|--------------:|--------------:|----------:|----------:|---------:|------------:|
| Bad_NPlus1            | 23,462.136 us | 1,069.2095 us | 3,135.8066 us | 1062.5000 | 1031.2500 | 250.0000 | 17091.48 KB |
| Fixed_NPlus1          |     39.657 us |     0.7977 us |     0.9186 us |    5.7983 |    0.6104 |        - |   107.17 KB |
| Bad_Cartesian         |      8.729 us |     0.1707 us |     0.2392 us |    0.4272 |         - |        - |     8.06 KB |
| Fixed_Cartesian       |    917.994 us |     6.8935 us |     5.7564 us |         - |         - |        - |     1.83 KB |
| Bad_PrematureToList   |  2,126.798 us |    28.9512 us |    27.0809 us |   89.8438 |   89.8438 |  89.8438 |  1859.62 KB |
| Fixed_PrematureToList |  1,659.137 us |    26.3353 us |    23.3456 us |   64.4531 |   64.4531 |  64.4531 |  1243.88 KB |

## Project Structure
