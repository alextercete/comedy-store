# Get jokes

`GET /jokes`

## Filters

| Filter | Description                                                                           |
|--------|---------------------------------------------------------------------------------------|
| `sort` | Sort results using format `<field> <order>`, where `order` is either `asc` or `desc`. |

## Example

### Request

```http
GET /jokes?sort=likes+desc HTTP/1.1
Accept: application/json
```

### Response

```http
HTTP/1.1 200 OK
Content-Type: application/json

[
    {
        "id": 123,
        "text": "Knock, knock",
        "likes": 45
    },
    {
        "id": 456,
        "text": "What do you call a joke that is not funny? A joke!",
        "likes": 7
    }
]
```
