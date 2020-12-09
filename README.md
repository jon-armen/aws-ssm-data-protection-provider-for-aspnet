![.NET on AWS Banner](./logo.png ".NET on AWS")

# AWS Systems Manager ASP.NET Core Data Protection Provider
[![nuget](https://img.shields.io/nuget/v/Amazon.AspNetCore.DataProtection.SSM.svg)](https://www.nuget.org/packages/Amazon.AspNetCore.DataProtection.SSM/)

[Amazon.AspNetCore.DataProtection.SSM](https://www.nuget.org/packages/Amazon.AspNetCore.DataProtection.SSM/) allows you to use [AWS Systems Manager](https://aws.amazon.com/systems-manager/)'s [Parameter Store](https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-paramstore.html) to store keys generated by ASP.NET's Data Protection API.
This enables you to scale by allowing multiple web servers to share the keys.

The library introduces the following dependencies:

* [AWSSDK.SimpleSystemsManagement](https://www.nuget.org/packages/AWSSDK.SimpleSystemsManagement/)
* [Microsoft.AspNetCore.DataProtection.Extensions](https://www.nuget.org/packages/Microsoft.AspNetCore.DataProtection.Extensions/)

# Getting Started

Follow the examples below to see how the library can be integrated into your application.

## ASP.NET Core Example
```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddDataProtection()
        .PersistKeysToAWSSystemsManager("/MyApplication/DataProtection");

    services.AddMvc();
}
```
## Getting Help

Please use these community resources for getting help. We use the GitHub issues
for tracking bugs and feature requests.

* Open a support ticket with [AWS Support](https://console.aws.amazon.com/support/home#/)
* If it turns out that you may have found a bug,
  please open an [issue](https://github.com/aws/aws-ssm-data-protection-provider-for-aspnet/issues/new)

## Permissions

The AWS credentials used must have access to the **ssm:PutParameter** and **ssm:GetParametersByPath** 
service operations from AWS System Manager. Below is an example IAM policy
for those actions.

```javascript
{
    "Version": "2012-10-17",
    "Statement": [
        {
            "Sid": "rule1",
            "Effect": "Allow",
            "Action": [
                "ssm:PutParameter",
                "ssm:GetParametersByPath"
            ],
            "Resource": "*"
        }
    ]
}
```

If the `KMSKeyId` property is set during the `PersistKeysToAWSSystemsManager` method then the IAM Policy
will also need access to **kms:Encrypt** for the KMS key used.



## Contributing

We welcome community contributions and pull requests. See
[CONTRIBUTING](./CONTRIBUTING.md) for information on how to set up a development
environment and submit code.

# Additional Resources

[AWS Developer Center - Explore .NET on AWS](https://aws.amazon.com/developer/language/net/)
Find all the .NET code samples, step-by-step guides, videos, blog content, tools, and information about live events that you need in one place.

[AWS Developer Blog - .NET](https://aws.amazon.com/blogs/developer/category/programing-language/dot-net/)
Come see what .NET developers at AWS are up to!  Learn about new .NET software announcements, guides, and how-to's.

[@awsfornet](https://twitter.com/awsfornet)
Follow us on twitter!

# License

Libraries in this repository are licensed under the Apache 2.0 License.

See [LICENSE](./LICENSE) and [NOTICE](./NOTICE) for more information.
