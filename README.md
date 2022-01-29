# dotnet-react-firebase
A generic .NET 6 projects allowing using Firestore Database in React.


# Firebase connection
The Application Default Credentials for a Firebase connection needs to be generated for a specific Service Account in GCP.
https://cloud.google.com/iam/docs/creating-managing-service-account-keys

Generated file needs do be stored as a JSON file in a .NET project. Set the name of this file in the environment variable `GOOGLE_APPLICATION_CREDENTIALS`.