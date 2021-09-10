using Google.Cloud.Firestore;
using System;

namespace DotnetFirestoreDemoApp.Core
{
    public static class FirestoreManager
    {
        private static FirestoreDb firestoreDb;

        static FirestoreManager()
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", 
                @"C:\Users\busin\Documents\GitHub\dotnet-firestore-demo-app\DotnetFirestoreDemoApp.Core\dotnet-firestore-demo-app-3b7777cae070.json");

            firestoreDb = FirestoreDb.Create("dotnet-firestore-demo-app");
        }

        public static async void Create()
        {
            CollectionReference collectionReference = firestoreDb.Collection("demo");

            DocumentReference documentReference = await collectionReference.AddAsync(
                new { 
                    Name = "Jane", 
                    Surname = "Doe" 
                });
        }
    }
}
