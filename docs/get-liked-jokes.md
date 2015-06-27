# Get liked jokes

`GET /users/:email/liked-jokes`

## Route parameters

| Parameter | Remarks             |
|-----------|---------------------|
| `email`   | Must be URL-encoded |

## Errors

| Status Code | Reason                                    |
|-------------|-------------------------------------------|
| `404`       | No user with the provided email was found |

## Example

### Request

```http
GET /users/coyote%40acme%2Ecom/liked-jokes HTTP/1.1
Accept: application/json
```

### Response

```http
HTTP/1.1 200 OK
Content-Type: application/json

[
    123,
    456,
    789
]
```
