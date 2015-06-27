# Comedy Store

## API documentation

| Verb     | Resource                        | Description                                    |
|----------|---------------------------------|------------------------------------------------|
| `PUT`    | `/users/:email`                 | [Create a user](docs/create-a-user.md)         |
| `GET`    | `/users/:email`                 | [Get a user](docs/get-a-user.md)               |
| `PUT`    | `/users/:email/liked-jokes/:id` | [Add liked joke](docs/add-liked-joke.md)       |
| `DELETE` | `/users/:email/liked-jokes/:id` | [Remove liked joke](docs/remove-liked-joke.md) |
| `GET`    | `/users/:email/liked-jokes`     | [Get liked jokes](docs/get-liked-jokes.md)     |
| `PUT`    | `/users/:email/seen-jokes/:id`  | [Add seen joke](docs/add-seen-joke.md)         |
| `GET`    | `/jokes`                        | [Get jokes](docs/get-jokes.md)                 |
| `GET`    | `/jokes/random`                 | [Get random joke](docs/get-random-joke.md)     |
