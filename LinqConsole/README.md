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

## Project Structure
