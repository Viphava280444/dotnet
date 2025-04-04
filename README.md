# Simple .NET Core 8 API with HTML Frontend

This is a simple .NET Core 8 application that provides both a RESTful API endpoint and a basic HTML frontend.



## API Endpoints

- `GET /api/messages` - Get all messages



## How to Build and Run



### Using Docker

1. Navigate to the SimpleApi directory
2. Build the Docker image:
   ```
   docker build -t dotnet-simple-api -f Dockerfile .
   ```
3. Run the container:
   ```
   docker run -p 8080:80 dotnet-simple-api
  