# hc-6396

https://github.com/ChilliCream/graphql-platform/issues/6396

- `dotnet watch --no-hot-reload`
- Query:
    ```gql
    mutation test($timestamp: Long) {
        addBook(timestamp: $timestamp) {
            title
        }
    }
    ```
- Variables:
    ```json
    {
        "timestamp": 820454400000
    }
    ```

> Incorrect type. Expected "null".
