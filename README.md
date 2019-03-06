# rc-csharp-sdk-demo

Demo app, play with [RingCentral Csharp SDK](https://github.com/ringcentral/RingCentral.Net)

## Run

```bash
git clone git@github.com:zxdong262/rc-csharp-sdk-demo.git
cd rc-csharp-sdk-demo

# create .env
cp .sample.env .env

# fill all fields in .env, make sure you app support password flow, a private mobile app would do
# you can check this image https://cloud.githubusercontent.com/assets/733544/18026560/b93e5356-6c7d-11e6-92a9-d35d28325e69.png

# run it
dotnet run

# will show
Hello World!
RingCentral.GetAccountInfoResponse
```