namespace hc_6396.Types;

[MutationType]
public static class Mutation
{
    public static Book AddBook(long? timestamp)
        => new Book("C# in depth.", new Author("Jon Skeet"));
}
