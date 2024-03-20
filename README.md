
# Basic Memory Cache

A small application to show memory cache usage in asp net web api.

In this project you go learn how to work memory cache in web api.

Basicly when you use memory cache make call in memory cache with a MemoryCacheKey to check this exists in application memory.

If yes memory cache return the list, object or anything information save in cache and don't need to make call in api/database or anything another source to get value.

With this your save consumption and get the best performance in application and response.


## API Reference

#### Get address info by zipCode

```http
  GET /api/viacep/v1/${zipCode}
```
 

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `zipCode`      | `string` | **Required**. ZipCode for Search |

Return info of  zipCode.


## Installation

You need install dot net 8.

- [Dot Net 8](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0)


Clone projeto

- Url to clone - https://github.com/RaphaZ99/basic-memory-cache.git

 
 Run project with visual studio
    
## Authors

- [@raphadev](https://www.linkedin.com/in/raphael-mota-560b29189/)
 

