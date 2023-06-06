﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.NET.Build.Containers.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.NET.Build.Containers.Resources.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER0000: Value for unit test {0}.
        /// </summary>
        internal static string _Test {
            get {
                return ResourceManager.GetString("_Test", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER1002: Request to Amazon Elastic Container Registry failed prematurely. This is often caused when the target repository does not exist in the registry..
        /// </summary>
        internal static string AmazonRegistryFailed {
            get {
                return ResourceManager.GetString("AmazonRegistryFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER2008: Both {0} and {1} were provided, but only one or the other is allowed..
        /// </summary>
        internal static string AmbiguousTags {
            get {
                return ResourceManager.GetString("AmbiguousTags", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER2009: Could not parse {0}: {1}.
        /// </summary>
        internal static string BaseImageNameParsingFailed {
            get {
                return ResourceManager.GetString("BaseImageNameParsingFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER2013: {0} had spaces in it, replacing with dashes..
        /// </summary>
        internal static string BaseImageNameWithSpaces {
            get {
                return ResourceManager.GetString("BaseImageNameWithSpaces", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER2020: {0} does not specify a registry and will be pulled from Docker Hub. Please prefix the name with the image registry, for example: '{1}/<image>'..
        /// </summary>
        internal static string BaseImageNameRegistryFallback {
            get {
                return ResourceManager.GetString("BaseImageNameRegistryFallback", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to CONTAINER1011: Couldn&apos;t find matching base image for {0} that matches RuntimeIdentifier {1}..
        /// </summary>
        internal static string BaseImageNotFound {
            get {
                return ResourceManager.GetString("BaseImageNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER1001: Failed to upload blob to {0}; received {1} with detail {2}..
        /// </summary>
        internal static string BlobUploadFailed {
            get {
                return ResourceManager.GetString("BlobUploadFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER1007: Could not deserialize token from JSON..
        /// </summary>
        internal static string CouldntDeserializeJsonToken {
            get {
                return ResourceManager.GetString("CouldntDeserializeJsonToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER2012: Could not recognize registry &apos;{0}&apos;..
        /// </summary>
        internal static string CouldntRecognizeRegistry {
            get {
                return ResourceManager.GetString("CouldntRecognizeRegistry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER3002: Failed to get docker info({0})\n{1}\n{2}.
        /// </summary>
        internal static string DockerInfoFailed {
            get {
                return ResourceManager.GetString("DockerInfoFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER3002: Failed to get docker info: {0}.
        /// </summary>
        internal static string DockerInfoFailed_Ex {
            get {
                return ResourceManager.GetString("DockerInfoFailed_Ex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER3001: Failed creating docker process..
        /// </summary>
        internal static string DockerProcessCreationFailed {
            get {
                return ResourceManager.GetString("DockerProcessCreationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER4006: Property &apos;{0}&apos; is empty or contains whitespace and will be ignored..
        /// </summary>
        internal static string EmptyOrWhitespacePropertyIgnored {
            get {
                return ResourceManager.GetString("EmptyOrWhitespacePropertyIgnored", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER4004: Items &apos;{0}&apos; contain empty item(s) which will be ignored..
        /// </summary>
        internal static string EmptyValuesIgnored {
            get {
                return ResourceManager.GetString("EmptyValuesIgnored", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER1008: Failed retrieving credentials for &quot;{0}&quot;: {1}.
        /// </summary>
        internal static string FailedRetrievingCredentials {
            get {
                return ResourceManager.GetString("FailedRetrievingCredentials", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No host object detected..
        /// </summary>
        internal static string HostObjectNotDetected {
            get {
                return ResourceManager.GetString("HostObjectNotDetected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER1009: Failed to load image to local registry. stdout: {0}.
        /// </summary>
        internal static string ImageLoadFailed {
            get {
                return ResourceManager.GetString("ImageLoadFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER1010: Pulling images from local registry is not supported..
        /// </summary>
        internal static string ImagePullNotSupported {
            get {
                return ResourceManager.GetString("ImagePullNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER2014: Invalid {0}: {1}..
        /// </summary>
        internal static string InvalidContainerImageName {
            get {
                return ResourceManager.GetString("InvalidContainerImageName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER2015: {0}: &apos;{1}&apos; was not a valid Environment Variable. Ignoring..
        /// </summary>
        internal static string InvalidEnvVar {
            get {
                return ResourceManager.GetString("InvalidEnvVar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER2005: The first character of the image name must be a lowercase letter or a digit..
        /// </summary>
        internal static string InvalidImageName {
            get {
                return ResourceManager.GetString("InvalidImageName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER2017: A ContainerPort item was provided with an invalid port number &apos;{0}&apos;. ContainerPort items must have an Include value that is an integer, and a Type value that is either &apos;tcp&apos; or &apos;udp&apos;..
        /// </summary>
        internal static string InvalidPort_Number {
            get {
                return ResourceManager.GetString("InvalidPort_Number", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER2017: A ContainerPort item was provided with an invalid port number &apos;{0}&apos; and an invalid port type &apos;{1}&apos;. ContainerPort items must have an Include value that is an integer, and a Type value that is either &apos;tcp&apos; or &apos;udp&apos;..
        /// </summary>
        internal static string InvalidPort_NumberAndType {
            get {
                return ResourceManager.GetString("InvalidPort_NumberAndType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER2017: A ContainerPort item was provided with an invalid port type &apos;{0}&apos;. ContainerPort items must have an Include value that is an integer, and a Type value that is either &apos;tcp&apos; or &apos;udp&apos;..
        /// </summary>
        internal static string InvalidPort_Type {
            get {
                return ResourceManager.GetString("InvalidPort_Type", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER2018: Invalid SDK prerelease version &apos;{0}&apos; - only &apos;rc&apos; and &apos;preview&apos; are supported..
        /// </summary>
        internal static string InvalidSdkPrereleaseVersion {
            get {
                return ResourceManager.GetString("InvalidSdkPrereleaseVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER2019: Invalid SDK semantic version &apos;{0}&apos;..
        /// </summary>
        internal static string InvalidSdkVersion {
            get {
                return ResourceManager.GetString("InvalidSdkVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER2007: Invalid {0} provided: {1}. Image tags must be alphanumeric, underscore, hyphen, or period..
        /// </summary>
        internal static string InvalidTag {
            get {
                return ResourceManager.GetString("InvalidTag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER2010: Invalid {0} provided: {1}. {0} must be a semicolon-delimited list of valid image tags. Image tags must be alphanumeric, underscore, hyphen, or period..
        /// </summary>
        internal static string InvalidTags {
            get {
                return ResourceManager.GetString("InvalidTags", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER1003: Token response had neither token nor access_token..
        /// </summary>
        internal static string InvalidTokenResponse {
            get {
                return ResourceManager.GetString("InvalidTokenResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER4005: Item &apos;{0}&apos; contains items without metadata &apos;Value&apos;, and they will be ignored..
        /// </summary>
        internal static string ItemsWithoutMetadata {
            get {
                return ResourceManager.GetString("ItemsWithoutMetadata", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER1012: The local registry is not available, but pushing to a local registry was requested.
        /// </summary>
        internal static string LocalRegistryNotAvailable {
            get {
                return ResourceManager.GetString("LocalRegistryNotAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER2004: Unable to download layer with descriptor &apos;{0}&apos; from registry &apos;{1}&apos; because it does not exist..
        /// </summary>
        internal static string MissingLinkToRegistry {
            get {
                return ResourceManager.GetString("MissingLinkToRegistry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER2016: ContainerPort item &apos;{0}&apos; does not specify the port number. Please ensure the item&apos;s Include is a port number, for example &apos;&lt;ContainerPort Include=&quot;80&quot; /&gt;&apos;.
        /// </summary>
        internal static string MissingPortNumber {
            get {
                return ResourceManager.GetString("MissingPortNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER1004: No RequestUri specified..
        /// </summary>
        internal static string NoRequestUriSpecified {
            get {
                return ResourceManager.GetString("NoRequestUriSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; was not a valid container image name, it was normalized to &apos;{1}&apos;.
        /// </summary>
        internal static string NormalizedContainerName {
            get {
                return ResourceManager.GetString("NormalizedContainerName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER2011: {0} &apos;{1}&apos; does not exist.
        /// </summary>
        internal static string PublishDirectoryDoesntExist {
            get {
                return ResourceManager.GetString("PublishDirectoryDoesntExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER1013: Failed to push to the output registry: {0}.
        /// </summary>
        internal static string RegistryOutputPushFailed {
            get {
                return ResourceManager.GetString("RegistryOutputPushFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER1005: Registry push failed..
        /// </summary>
        internal static string RegistryPushFailed {
            get {
                return ResourceManager.GetString("RegistryPushFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER4003: Required &apos;{0}&apos; items contain empty items..
        /// </summary>
        internal static string RequiredItemsContainsEmptyItems {
            get {
                return ResourceManager.GetString("RequiredItemsContainsEmptyItems", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER4002: Required &apos;{0}&apos; items were not set..
        /// </summary>
        internal static string RequiredItemsNotSet {
            get {
                return ResourceManager.GetString("RequiredItemsNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER4001: Required property &apos;{0}&apos; was not set or empty..
        /// </summary>
        internal static string RequiredPropertyNotSetOrEmpty {
            get {
                return ResourceManager.GetString("RequiredPropertyNotSetOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER1006: Too many retries, stopping..
        /// </summary>
        internal static string TooManyRetries {
            get {
                return ResourceManager.GetString("TooManyRetries", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER2002: Unknown local registry type &apos;{0}&apos;. Valid local container registry types are {1}..
        /// </summary>
        internal static string UnknownLocalRegistryType {
            get {
                return ResourceManager.GetString("UnknownLocalRegistryType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER2003: The manifest for {0}:{1} from registry {2} was an unknown type: {3}. Please raise an issue at https://github.com/dotnet/sdk-container-builds/issues with this message..
        /// </summary>
        internal static string UnknownMediaType {
            get {
                return ResourceManager.GetString("UnknownMediaType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONTAINER2001: Unrecognized mediaType &apos;{0}&apos;..
        /// </summary>
        internal static string UnrecognizedMediaType {
            get {
                return ResourceManager.GetString("UnrecognizedMediaType", resourceCulture);
            }
        }
    }
}
