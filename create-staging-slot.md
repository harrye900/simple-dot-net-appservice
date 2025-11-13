# Create Staging Slot

Run this command to create a staging slot:

```bash
az webapp deployment slot create --name mywebapp-cli-check --resource-group rg-cli-webapp --slot staging
```

## After creating the slot:

**Production URL**: https://mywebapp-cli-check.azurewebsites.net/
**Staging URL**: https://mywebapp-cli-check-staging.azurewebsites.net/

## To get staging publish profile:

```bash
az webapp deployment list-publishing-profiles --name mywebapp-cli-check --resource-group rg-cli-webapp --slot staging --xml
```