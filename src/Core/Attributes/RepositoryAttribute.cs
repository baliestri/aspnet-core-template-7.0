﻿// Copyright (c) Bruno Sales <me@baliestri.dev>. Licensed under the MIT License.
// See the LICENSE file in the repository root for full license text.

namespace ASPNETCoreTemplate.Core.Attributes;

/// <summary>
///   Attribute to mark a class or interface as a repository.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, Inherited = false)]
public sealed class RepositoryAttribute : Attribute { }
