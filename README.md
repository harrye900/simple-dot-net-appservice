# Simple .NET Web App for Azure

A minimal ASP.NET Core web application ready for Azure Web App deployment.

## Setup Instructions

### 1. Create Azure Web App
```bash
# Login to Azure
az login

# Create resource group
az group create --name myResourceGroup --location "East US"

# Create App Service plan
az appservice plan create --name myAppServicePlan --resource-group myResourceGroup --sku FREE

# Create Web App
az webapp create --resource-group myResourceGroup --plan myAppServicePlan --name your-unique-app-name --runtime "DOTNETCORE|8.0"
```

### 2. Configure GitHub Deployment
1. Go to your Azure Web App in the portal
2. Navigate to Deployment Center
3. Choose GitHub as source
4. Select your repository and branch
5. Download the publish profile and add it as `AZUREAPPSERVICE_PUBLISHPROFILE` secret in GitHub

### 3. Update Workflow
- Edit `.github/workflows/azure-webapps-dotnet-core.yml`
- Replace `your-app-name` with your actual Azure Web App name

## Local Development
```bash
dotnet run
```

Visit `http://localhost:5000` to see the app running locally.

## Endpoints
- `/` - Hello World message
- `/health` - Health check endpoint