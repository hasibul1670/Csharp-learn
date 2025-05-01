<a name="top"></a>
# Csharp-learn
C# Language-Specific Learning Path


## Table of Contents
- [Object-Oriented Programming (OOP)](#object-oriented-programming-oop)
- [Constructors and Destructors](#constructors-and-destructors)
- [this, base, and params keywords](#this-base-and-params-keywords)
- [Properties and Indexers](#properties-and-indexers)
- [Inheritance and Polymorphism](#inheritance-and-polymorphism)
- [Abstract Classes and Interfaces](#abstract-classes-and-interfaces)
- [Static Classes and Members](#static-classes-and-members)
- [Enums and Structs](#enums-and-structs)
- [Exception Handling and Custom Exceptions](#exception-handling-and-custom-exceptions)
- [Collections](#collections)
- [File IO and Streams](#file-io-and-streams)
- [Nullable Types](#nullable-types)
- [Delegates and Events](#delegates-and-events)
- [Lambda Expressions](#lambda-expressions)
- [LINQ](#linq)
- [Generics](#generics)
- [Extension Methods](#extension-methods)
- [Immutability](#immutability-and-immutability-patterns)
- [Asynchronous Programming](#asynchronous-programming-asyncawait)
- [ValueTask and IAsyncEnumerable](#valuetask-and-iasyncenumerable)
- [Multithreading](#multithreading-and-parallel-programming)
- [Task Thread ThreadPool](#task-thread-threadpool)
- [Func Action Predicate](#delegates-vs-func-vs-action-vs-predicate)
- [Reflection](#reflection)
- [Attributes](#attributes-and-custom-attributes)
- [Expression Trees](#expression-trees)
- [Dynamic Types](#dynamic-types-and-expandoobject)
- [Memory Management](#memory-management-and-garbage-collection)
- [Span Memory](#spant-and-memoryt)
- [Unsafe Code](#unsafe-code-and-pointers)
- [IEnumerable vs IQueryable](#ienumerable-vs-iqueryable)
- [Custom LINQ Providers](#custom-linq-providers)
- [Nullable Reference Types](#nullable-reference-types-c-8)
- [Record Types](#record-types-and-init-only-properties-c-9)
- [Pattern Matching](#pattern-matching-enhancements-c-8910)
- [Global Usings](#global-usings-and-file-scoped-namespaces)
- [Top-Level Statements](#top-level-statements)

## Object-Oriented Programming (OOP)

> 

```csharp
public class School{
    string name;
    int estd;
    // class name == method name called constructor
    // use  for get and set value in run time
    public School(){
        System.Console.WriteLine("Default Constructor------>");
    }

      public School(string n,int e){
        System.Console.WriteLine("Default Constructor");
        System.Console.WriteLine($"{n}---> {e}");

    }

}
```


[🔝 Back to Top](#table-of-contents)



## Access Modifiers

> 




[🔝 Back to Top](#table-of-contents)
...

## Top-Level Statements

> Final topic content.

## Properties and Indexers







 - .NET CLI and SDK-style Projects
 - Assemblies and AppDomains
 - Unit Testing and TDD
 - Dependency Injection
 - Design Patterns (Singleton, Factory, Strategy, etc.)
 - Entity Framework Core (EF Core) and Database Access
 - Blazor and Razor Components
 - Minimal APIs in .NET
 - Building Custom Middleware in ASP.NET Core
 - gRPC in .NET
 - .NET MAUI for Cross-Platform Apps
 - C# Interop with WebAssembly (Beyond Blazor)
 - Cloud-Native Development with .NET
 - Localization and Globalization
 - Performance Tuning and Benchmarking (BenchmarkDotNet)
 - Advanced Diagnostics and Profiling
 - Hot Reload and Development Productivity
 - AOT (Ahead-of-Time) Compilation and Native AOT
 - Interoperability with unmanaged code (P/Invoke)
 - Roslyn Compiler APIs
 - Source Generators
 - Code Analysis and Roslyn Analyzers