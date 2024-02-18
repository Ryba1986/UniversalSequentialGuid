# UniversalSequentialGuid

The UniversalSequentialGuid library provides a simple yet powerful solution for generating sequential GUIDs on the .NET platform, catering to various database engines while accommodating their sorting systems.

### Key Features:
1. **Cross-Platform Compatibility:** Works seamlessly across different platforms supported by .NET, ensuring consistent behavior regardless of the underlying operating system or database engine.

2. **Sequential GUID Generation:** Generates GUIDs in a strictly sequential manner, facilitating efficient indexing and optimized performance, especially in scenarios involving large datasets or high-volume transactions.

3. **Database Engine Support:** Offers comprehensive support for various database engines, including but not limited to SQL Server, PostgreSQL. The library adapts its GUID generation strategy based on the specific requirements and sorting systems of each database engine.

4. **Customizable Configuration:** Allows users to fine-tune the GUID generation process through customizable configuration options, enabling adjustments based on specific database configurations, performance considerations, or application requirements.

5. **Optimized Sorting:** Optimizes GUID generation to ensure compatibility with the sorting systems employed by different database engines, thereby enhancing query performance and data retrieval efficiency.

### Usage Example:
```csharp
// Initialize generator for .NET
var generator = new SequentialGenerator();

// Generate sequential GUID for SQL Server
var generator = new SequentialGenerator(new () { GuidType = GuidType.MsSql });
var sqlServerGuid = generator.NewGuid();

// Generate sequential GUID for PostgreSQL
var generator = new SequentialGenerator(new () { GuidType = GuidType.PostgreSql });
var postgreSqlGuid = generator.NewGuid();
```

### Get Started:
To start using the UniversalSequentialGuid library in your .NET projects, simply install the package via NuGet Package Manager or include it as a dependency in your project configuration file. Refer to the official documentation for detailed installation instructions and usage guidelines.

Experience the efficiency and performance benefits of sequential GUID generation tailored to the specific requirements of your database engine with the UniversalSequentialGuid library. Unlock the full potential of your .NET applications while ensuring compatibility, scalability, and reliability across diverse database environments.

**Installation:**
Install the UniversalSequentialGuid library via NuGet Package Manager:
```
Install-Package UniversalSequentialGuid
```

**License:**
UniversalSequentialGuid is licensed under the MIT License, permitting both personal and commercial usage with minimal restrictions.

**Support:**
For inquiries or issue reporting, please utilize the GitHub issue tracker associated with the UniversalSequentialGuid repository.
