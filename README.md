# core-comparison
to share some reflections on some important differences between .NET 4.xx and .NET Core 2.2
also, some important maths problems present in .NET 4.72 and earlier still remain in .NET Core 2.2
e.g. divide by zero, log(0 or negative number), sqrt(negative number), pow(negative number, positive fraction)
still FAIL SILENTLY in all current versions of .NET and .NET Core
See https://pjlee.net/blog/some-maths-problems-from-net-472-and-earlier-are-still-present-in-net-core-22 for an article on this
