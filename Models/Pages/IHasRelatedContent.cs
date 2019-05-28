using EPiServer.Core;

namespace EpiserverSampleProject.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
