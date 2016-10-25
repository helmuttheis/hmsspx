# hmsspx
A SharePoint explorer for Xamarin Forms

**Still under construction**

HMSSPX is a Xamarin.Forms application that can be used to browse WebSites on SharePoint servers.

![](http://i.imgur.com/tWaWFwg.png)

At the first start you have to select **Setup** in order to specify the URLs and credentials. 

![](http://i.imgur.com/hcSCRJk.png)

In the lower right corner the currently selected credentials are displayed.

Select the Back button and than **Browse**. You will see the list of all properties.

![](http://i.imgur.com/fSaUdk9.png)

The ![](http://i.imgur.com/wz1inhs.png) sign indicates a list or collection of properties, that will be inserted in this view.

The ![](http://i.imgur.com/ESlCfKn.png) sign indicates a SharePoint object that will be opened in a new view. You can return to the previous view by selecting the Back button.

![](http://i.imgur.com/L5otntE.png)

When a collection is expanded, only a limited set of entries are displayed.
Here only 10 entries are displayed and 605 entries are skipped.

## Limitations
### SharePoint 2010
SharePoint 2010 exposes only a limited REST API.

You will get only the list of lists. 

### iOS 
