# Get random joke

`GET /jokes/random`

## Filters

| Filter     | Description                                                         |
|------------|-------------------------------------------------------------------- |
| `unseenBy` | Try to provide a joke that hasn't been seen by the specified author |

## Example

### Request

```http
GET /jokes/random?unseenBy=coyote@acme.com HTTP/1.1
Accept: application/json
```

### Response

```http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "id": 123,
    "text": "Knock, knock",
    "likes": 45
}
```
