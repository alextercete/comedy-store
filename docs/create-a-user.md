# Create a user

`PUT /users/:email`

## Route parameters

| Parameter | Remarks             |
|-----------|---------------------|
| `email`   | Must be URL-encoded |

## Fields

| Field  | Type         | Description   |
|--------|--------------|---------------|
| `name` | **required** | The user name |

## Errors

| Status Code | Reason                                        |
|-------------|-----------------------------------------------|
| `400`       | One or more required fields were not provided |

## Example

### Request

```http
PUT /users/coyote%40acme%2Ecom HTTP/1.1
Accept: application/json
Content-Type: application/json

{
  "name": "Wile E. Coyote"
}
```

### Response

```http
HTTP/1.1 201 Created
Content-Type: application/json

{
  "email": "coyote@acme.com",
  "name": "Wile E. Coyote"
}
```
