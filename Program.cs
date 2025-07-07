// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Testing build pipeline trigger!");
Console.WriteLine($"Build triggered at: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
Console.WriteLine("Pipeline test commit lần 3 - " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
Console.WriteLine("Pipeline test commit lần 4 - " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
// Test app-main build
// Test app-main dependency build - Mon Jul  7 12:53:12 +07 2025
// New commit to test build pipeline - $(date)
// Second commit test - July 7, 2025 3:17 PM
// Test commit lần 4 - July 7, 2025 10:30 AM
// Test commit for pipeline after adding .sln - Mon Jul  7 19:36:23 +07 2025
