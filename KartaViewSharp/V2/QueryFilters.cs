﻿using System;
using System.Globalization;
using ISO3166;
using NetTopologySuite.Geometries;

namespace KartaViewSharp.V2;

public abstract class QueryFilters
{
    /// <summary>
    /// Unique identifier of an entity, query for a set of ids is possible, separated by ,. For example: id=545,546,547
    /// </summary>
    public int[]? Id { get; set; }

    /// <summary>
    /// Unique identifier of an entity, query for an interval of ids is possible, separated by -. For example: idInterval=545-547
    /// </summary>
    public Range? IdInterval { get; set; }

    /// <summary>
    /// Retrieve data from the desired page number.
    /// </summary>
    public int? Page { get; set; }

    /// <summary>
    /// Default: 40
    /// Example: itemsPerPage=10
    /// Number of items on a page.
    /// </summary>
    public int ItemsPerPage { get; set; } = 40;

    /// <summary>
    /// Example: orderBy=dateAdded
    /// Sorting by a particular field, see full list below in the response example section.
    /// </summary>
    public string OrderBy { get; set; }

    /// <summary>
    /// Enum: "asc" "desc"
    /// Sorting direction.
    /// </summary>
    public OrderDirection OrderDirection { get; set; }

    /// <summary>
    /// Default: "metric"
    /// Enum: "metric" "imperial"
    /// The type of the distance measurement.
    /// </summary>
    public Units Units { get; set; }

    /// <summary>
    /// Default: "null"
    /// Example: join=user,photo
    /// Join resources to bring extra details about another resource, available joinable resource: user, photo, photos, attachment, attachments.
    /// </summary>
    public string[]? Join { get; set; }
}

public class SequenceQueryFilters : QueryFilters
{
    /// <summary>
    /// Unique identifier of an user entity.
    /// </summary>
    public string[] UserIds { get; set; }

    /// <summary>
    /// Top,Left coordinates for the bounding box.
    /// </summary>
    public Coordinate? TopLeft { get; set; }

    /// <summary>
    /// Bottom,Right coordinates for the bounding box.
    /// </summary>
    public Coordinate? BottomRight { get; set; }

    /// <summary>
    /// Retrieve all sequences that have attachments.
    /// </summary>
    public bool? WithAttachments { get; set; }

    /// <summary>
    /// Example: withPhotos=true
    /// Retrieve all sequences that have photos.
    /// </summary>
    public bool? WithPhotos { get; set; }

    /// <summary>
    /// Default: null
    /// Example: countryCode=US
    /// Country Code initials, ISO-2 format.
    /// </summary>
    public Country? CountryCode { get; set; }

    /// <summary>
    /// The starting point of the date interval.
    /// </summary>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// The ending point of the date interval.
    /// </summary>
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// The status of the sequence.
    /// </summary>
    public SequenceStatus? SequenceStatus { get; set; }

    /// <summary>
    /// The platform of the device that recorded the file.
    /// </summary>
    public Platform? Platform { get; set; }

    /// <summary>
    /// Type of the user.
    /// </summary>
    public UserType? UserType { get; set; }

    /// <summary>
    /// Type of the sequence.
    /// </summary>
    public SequenceType? SequenceType { get; set; }

    /// <summary>
    /// Unique identifier representing a specific region. Multiple regions can be provided.
    /// </summary>
    public Region[]? Region { get; set; }
}

public class PhotoQueryFilters : QueryFilters
{
	/// <summary>
	/// Unique identifier representing a specific sequence.
	/// </summary>
	public int? SequenceId { get; set; }

	/// <summary>
	/// Identifier representing a specific image index.
	/// </summary>
	public int? SequenceIndex { get; set; }

    /// <summary>
    /// Enum: "photo" "video" "vdb"
    /// Example: searchSequenceType=vdb
    /// Type of the sequence. Used only for findNearbyPhotos functionality.
    /// </summary>
    public SequenceType? SearchSequenceType { get; set; }

	/// <summary>
	/// The platform of the device that recorded the file. Used only for findNearbyPhotos functionality.
	/// </summary>
	public Platform? SearchPlatform { get; set; }

	/// <summary>
	/// The field of view type. Used only for findNearbyPhotos functionality.
	/// </summary>
	public FieldOfView? SearchFieldOfView { get; set; }

	/// <summary>
	/// Unique identifier of an user entity.
	/// </summary>
	public string[] UserIds { get; set; }

    /// <summary>
    /// Identifier representing a specific video index.
    /// </summary>
	public int? VideoIndex { get; set; }

	/// <summary>
	/// The distortion type of the photo.
	/// </summary>
	public Projection Projection { get; set; }

    public Coordinate? Location { get; set; }

    public string? Radius { get; set; }

    public int? ZoomLevel { get; set; } = 18;
}

public enum Projection
{
	Plane,
	Cylinder,
	Sphere,
	Fisheye,
	Cube
}

public enum FieldOfView
{
	Plane,
	_180,
	_360,
	DualFisheye
}

public enum SequenceType
{
    Vdb,
    Video,
    Photo
}

public enum UserType
{
    Regular,
    Driver,
    Byod,
    Dedicated,
    Internal
}

public enum Platform
{
    IOS,
    Android,
    Waylens,
    GoPro,
    Other
}

public enum SequenceStatus
{
    Public,
    Uploading,
    Processing,
    Failed,
    Deleted,
    New,
    Finished,
    VideoSplit,
    UploadFinished,
    ProcessingFinished,
    ProcessingFailed
}

public enum Units
{
    Metric,
    Imperial
}

public enum OrderDirection
{
    Ascending,
    Descending
}

public enum Region
{
    Atlanta = 1,
    Boston = 2,
    Calgary = 3,
    Canada = 4,
    Chicago = 5,
    CiudadDeMexico = 6,
    Cleveland = 7,
    Dallas = 8,
    Denver = 9,
    Detroit = 10,
    Ecuador = 11,
    Houston = 12,
    LosAngeles = 13,
    Mexico = 14,
    Miami = 15,
    Minneapolis = 16,
    Montreal = 17,
    NewYork = 18,
    Orlando = 19,
    Ottawa = 20,
    Philadelphia = 21,
    Phoenix = 22,
    Pittsburgh = 23,
    Portland = 24,
    SanJose = 25,
    Seattle = 26,
    StLouis = 27,
    Toronto = 28,
    US = 29,
    Vancouver = 30,
    Washington = 31,
    Europe = 32,
    Africa = 33,
    SouthAmerica = 34,
    Asia = 35,
    AustraliaOceania = 36,
    NorthAmerica = 37,
    CentralAmerica = 38,
    Australia = 39,
    NewZealand = 41,
    WesternAustralia = 297,
    SouthAustralia = 299,
    NewSouthWales = 301,
    Tasmania = 303,
    Victoria = 305,
    Queensland = 307,
    WestCoast = 311,
    Tasman = 313,
    Marlborough = 315,
    Nelson = 317,
    Taranaki = 319,
    Southland = 321,
    Wellington = 323,
    ManawatuWanganui = 325,
    HawkesBay = 327,
    Northland = 329,
    Waikato = 331,
    BayOfPlenty = 333,
    Gisborne = 335,
    Canterbury = 337,
    Auckland = 339,
    Otago = 341,
    AustralianCapitalTerritory = 373,
    Melbourne = 375,
    Sydney = 377,
    Adelaide = 379,
    Perth = 381,
    Ballarat = 383,
    Bendigo = 385,
    Geelong = 387,
    Brisbane = 389,
    Cairns = 391,
    Hobart = 393,
    NewcastleMaitland = 395,
    Darwin = 397,
    SunshineCoast = 399,
    Toowoomba = 401,
    Townsville = 403,
    Wollongong = 405,
    CanberraQueanbeyan = 437,
    Wellington_MA = 439,
    Christchurch = 441,
    Hamilton = 443,
    Dunedin = 445,
    Tauranga = 447,
    Auckland_MA = 449,
    NapierHastings = 451,
    JakartaMunicipality = 455,
    JakartaServiceArea = 459,
    Indonesia = 463,
    Vietnam = 467,
    HoChiMinhProvince = 471,
    HoChiMinhUrbanArea = 475,
    MetroManila = 479,
    Jakarta = 483,
    MakassarServiceArea = 1027,
    Makassar = 1031,
    KotaBandungServiceArea = 1035,
    KotaBandung = 1039,
    SurabayaCity = 1043,
    Surabaya = 1047,
    MedanCity = 1051,
    KotaMedan = 1055,
    Malaysia = 1059,
    KualaLumpurCity = 1064,
    KualaLumpur = 1067,
    Thailand = 1071,
    BangkokCity = 1075,
    BangkokMetropolis = 1079,
}