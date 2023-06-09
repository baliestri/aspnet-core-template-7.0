﻿// Copyright (c) Bruno Sales <me@baliestri.dev>. Licensed under the MIT License.
// See the LICENSE file in the repository root for full license text.

using ASPNETCoreTemplate.Application.Adapters;
using ASPNETCoreTemplate.Application.Schemas.Responses.Generic;
using MediatR;

namespace ASPNETCoreTemplate.Application.UseCases.Authentication.SignOut;

/// <summary>
///   Represents a sign out use case.
/// </summary>
/// <param name="RefreshToken"></param>
public sealed record SignOutUseCase(
  string RefreshToken
) : IRequest<ErrorOr<MessageResponseSchema>>;
