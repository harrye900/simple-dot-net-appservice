## Staging Deployment Setup

## Required GitHub Secrets:

You need **TWO** publish profiles:

### 1. Production Publish Profile:
- Name: `AZUREAPPSERVICE_PUBLISHPROFILE`
- Get from: Production slot (main app)

### 2. Staging Publish Profile:
- Name: `AZUREAPPSERVICE_PUBLISHPROFILE_STAGING`
- Get from: Staging slot

## How to get staging publish profile:

1. **Create staging slot first**:
   ```bash
   az webapp deployment slot create --name mywebapp-cli-check --resource-group rg-cli-webapp --slot staging
   ```

2. **Download staging publish profile**:
   ```bash
   az webapp deployment list-publishing-profiles --name mywebapp-cli-check --resource-group rg-cli-webapp --slot staging --xml
   ```

3. **Add to GitHub Secrets**:
   - Go to GitHub repo → Settings → Secrets and variables → Actions
   - Add secret: `AZUREAPPSERVICE_PUBLISHPROFILE_STAGING`
   - Paste the XML content

## Deployment Flow:
1. **Deploy to staging** → Test at `https://mywebapp-cli-check-staging.azurewebsites.net/`
2. **Swap to production** → Live at `https://mywebapp-cli-check.azurewebsites.net/`