namespace Microsoft.Azure.Management.Compute
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Azure.OData;
    using System.Linq.Expressions;
    using Microsoft.Azure;
    using Models;

    /// <summary>
    /// </summary>
    public partial interface IVirtualMachineImagesOperations
    {
        /// <summary>
        /// Gets a virtual machine image.
        /// </summary>
        /// <param name='location'>
        /// </param>
        /// <param name='publisherName'>
        /// </param>
        /// <param name='offer'>
        /// </param>
        /// <param name='skus'>
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<AzureOperationResponse<VirtualMachineImage>> GetWithHttpMessagesAsync(string location, string publisherName, string offer, string skus, string version, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of virtual machine image offers.
        /// </summary>
        /// <param name='location'>
        /// </param>
        /// <param name='publisherName'>
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<AzureOperationResponse<VirtualMachineImageResourceList>> ListOffersWithHttpMessagesAsync(string location, string publisherName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of virtual machine image publishers.
        /// </summary>
        /// <param name='location'>
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<AzureOperationResponse<VirtualMachineImageResourceList>> ListPublishersWithHttpMessagesAsync(string location, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of virtual machine image skus.
        /// </summary>
        /// <param name='location'>
        /// </param>
        /// <param name='publisherName'>
        /// </param>
        /// <param name='offer'>
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<AzureOperationResponse<VirtualMachineImageResourceList>> ListSkusWithHttpMessagesAsync(string location, string publisherName, string offer, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of virtual machine images.
        /// </summary>
        /// <param name='location'>
        /// </param>
        /// <param name='publisherName'>
        /// </param>
        /// <param name='offer'>
        /// </param>
        /// <param name='skus'>
        /// </param>
        /// <param name='filter'>
        /// The filter to apply on the operation.
        /// </param>
        /// <param name='top'>
        /// </param>
        /// <param name='orderby'>
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<AzureOperationResponse<VirtualMachineImageResourceList>> ListWithHttpMessagesAsync(string location, string publisherName, string offer, string skus, Expression<Func<Resource, bool>> filter = default(Expression<Func<Resource, bool>>), int? top = default(int?), string orderby = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}