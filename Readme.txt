git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/navneet499/UpdatedFinal.git
git push -u origin main


devops pipeline sequence
1. agent
2. Install
3. Restore
4. Build
5. Publish
6. Artifact....drop(Zipfile)
all six steps is said to be continous integration

Deployment-
a. Service connection...AzureResourcegroup...AzureWebapp...Deploy(Zipfile)
DotnetCoreService..NavneetWebApp
NavneetUpdatedConnection

15 July-
1. Introduction to dynamic migration
2. Integration of complete lyfe cycle with layered archtecture with entity framework core and finaly update to azure web NavneetWebApp(4)
3. Introduction to Azure key vault(1)
4. Introduction to Azure service bus***(2)
5. Azure Function****(3)
6. Telemetric Feature(Azure insight)(Resilency Pattern(Microservice))
7. Azure Kubernates Service(Most Important).......Docker...Kubernates(Deployment)(5)
8. Azure Storage(Cosmos db,Blob storage etc)(6) starter
.............................................................................................
Gateway(LocalDevelopment/Productiondevelopment)
Ocelot(Handson)
Azure APIM****(Gateway)


20 july-

Conclusion-
Now we have to apply complete dotnet application with functioning 
...............................................................................................
22 july-
application is deployed on Azure with production Feature
Introduction to Azure key vault-
1. Can u explain the architecture of Azure Key vault
2. If u have worked in project tell me the library name , classes name, function name used in a project
3. What kind of configuration you have done in program.cs file
4. What kind of configuration you have done in appsetting.json file **
 ........................................................................................................
 Major packages to install to implement azure key vault
 dotnet add package Azure.Identity
dotnet add package Azure.Security.KeyVault.Secrets
dotnet add package Azure.Extensions.AspNetCore.Configuration.Secrets

1. the purpose of implement azure key vault is to secure the connection string beacuse we are using azure key vault to incript the 
connection string with digital signature with certificates
2. Azure key vault is the most imp service provider of azure
Azure Portal → Create a resource → Security → Key Vault
1. KeyVault
key vault name-mykeyvaultnavneet
region-India South Central
2. Secret
name of the Secret - DefaultConnection
3. Registration
Azure active directory now is Intra ID
..................................................................................................
22 July-
While we are creating secret key there is a issue with the policy
url for key vault(NavneetKeyVault1234) - https://navneetkeyvault1234.vault.azure.net/
secret key name - myconnection

25 july-Now we have to configure in program.cs for azure key vault beacuse generaly we use sql server
connection string of local server but connection string is secure and kept in centralized place known AspNetCore
azure key vault. 
step 1. {
  "KeyVault": {
    "VaultUri": "https://navneetkeyvault1234.vault.azure.net/"
  }
}
// Step 2: Key Vault ko configuration source ke roop mein add karo
builder.Configuration.AddAzureKeyVault(new Uri(kvUri), new DefaultAzureCredential());

// Step 2: appsettings.json se Key Vault URI read karo
string kvUri = builder.Configuration["KeyVault:VaultUri"]!;

// Step 3: Ab Key Vault se connection string uthao
string connectionString = builder.Configuration["SqlConnectionString"]!;
write a code written in program.cs

Logic-
Core application
Host                                          Key Vault(Seprate Service)Identity
Azure App service(Identity)

Logic- Key vault and dotnet core application are runinng both are seperate service so we have
to apply authentication using manage Identity

Server=tcp:employeeserver1.database.windows.net,1433;Initial Catalog=Employee;Persist Security Info=False;User ID=sqladmin;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;

30 july-
Storage Architecture-
1. Blob
2. Queue(Azure function and service bus)
3. Azure table storage
...................................................................................................
1. How to configure Azure function 
2. How to set up azure function in vscode/az is cli tool
3. Azure function also provide cli tool
npm install -g azure-functions-core-tools@4 --unsafe-perm true

in local development we use to create backend core web api known as rest full service and it support http verbs
get ,post,production
2. i data base triggr is meant for performing operation like event based
3. we can fire the trigger for insert,update deleete similarily in azure function is a light weight core web api
4. using azure function we create a function to call that function we have to perform the event exp event like http trigger
http trigger
timmer trigger
blob storage trigger
func init MyFunctionApp --worker-runtime dotnet
equal to- dotnet new wabapi --name service name