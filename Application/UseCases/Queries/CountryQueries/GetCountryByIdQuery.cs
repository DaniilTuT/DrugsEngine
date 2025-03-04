﻿using Domain.Entities;
using MediatR;

namespace Application.UseCases.Queries.CountryQueries;

public record GetCountryByIdQuery(Guid Id) : IRequest<Country?> ;