﻿using AuctionService.DTOs;
using AuctionService.Entities;
using AutoMapper;
using Contracts;

namespace SearchService;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        // CreateMap<Auction, AuctionDto>().IncludeMembers(x=>x.Item);
        // CreateMap<Item, AuctionDto>();
        // CreateMap<CreateAuctionDto,Auction>()
        //     .ForMember(d=>d.Item,o=>o.MapFrom(s=>s));
        // CreateMap<CreateAuctionDto,Item>();
        // CreateMap<AuctionDto,AuctionCreated>();
        CreateMap<AuctionCreated, Item>();
        CreateMap<AuctionUpdated, Item>();
    }
}