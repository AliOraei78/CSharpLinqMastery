# C# LINQ Mastery Showcase

A console application demonstrating comprehensive LINQ skills, including Method Syntax, Query Syntax, Deferred vs Immediate execution, complex queries, and performance optimization.

## LINQ Basics: Method Syntax & Query Syntax

### Features Demonstrated
- **Method Syntax** – Chainable extension methods (`Where`, `OrderBy`, `Select`, etc.).
- **Query Syntax** – SQL-like syntax using `from`, `where`, `orderby`, `select`.
- **Large Dataset** – 100,000 randomly generated `Person` objects using Bogus library.
- **10 Basic Queries** – 5 implemented in Method Syntax, 5 in Query Syntax (identical results).

### Key Queries (Method Syntax)
1. Adults over 50 years old
2. Sorted by salary descending
3. Projection to name and city
4. Top 10 youngest people
5. High salary earners in Tehran (example filtering)

### Key Queries (Query Syntax)
Same 5 queries rewritten using `from ... where ... select` syntax.

### Dataset
- `Person` model with Id, Name, Age, City, Salary.
- Generated 100,000 records with realistic random data.

## Project Structure
