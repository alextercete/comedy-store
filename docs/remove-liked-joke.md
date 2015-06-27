# Remove liked joke

`DELETE /users/:email/liked-jokes/:id`

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
DELETE /users/coyote%40acme%2Ecom/liked-jokes/123 HTTP/1.1
```

### Response

```http
HTTP/1.1 204 No Content
```
