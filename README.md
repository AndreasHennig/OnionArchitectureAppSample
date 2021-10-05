Onion Architecture Sample App
=============================

This is an example on how to create a Xamarin.Forms mobile app which a clean architecture using the onion architecture model.

# Projects
## Outer Layer
- UI
- Tests
- Infrastructure

## Application Core
- Application Services
- Domain Services
- Domain Model

This sample is quite dogmatic in the sense that it keeps every layer of the application core in a separate Visual Studio project (hence in a separate assembly).

Dependant on how large your app is you might consider to merge some of the layers and put them in a single Visual Studio project. This might be possible especially for the domain services layer and app services layer.

However, I would not recommend to put any component from the "outer shell" in a shared project with a component from the application core since this kind of butchers the whole idea of the onion architecture model. At least it makes it harder to maintain the correct direction of dependencies. The project references as set up in this sample help you to maintain the correct direction of the dependencies.
