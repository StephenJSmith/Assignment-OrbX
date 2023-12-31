using Domain;

namespace Persistence;

public class ProductsRepository : IProductsRepository
{
  public static string Fsx = "fsx";
  public static string Fsxe = "fsxe";
  public static string P3dv1 = "p3dv1";
  public static string P3dv2 = "p3dv2";
  public static string P3dv3 = "p3dv3";
  public static string P3dv4 = "p3dv4";
  public static string P3dv5 = "p3dv5";
  public static string Msfs = "msfs";
  public static string Xp11 = "xp11";
  public static string Afs2 = "afs2";

  private readonly List<Product> _products;
  private readonly List<string> _simulators;

  public ProductsRepository()
  {
    _products = GetSeededProducts();
    _simulators = GetSeededSimulators();
  }

  public List<Product> GetProducts()
  {
    return _products.ToList();
  }

  public List<Product> GetTopProductsForSimulator(
    string simulator, string sortField, string sortOrder, int skipItems, int takeItems)
  {
    // Dynamically build expression tree per passed sortField and sortOrder parameters
    var expression = _products
      .Where(p => p.Simulators.Any(s => s == simulator.ToLower()))
      .OrderByDescending(p => p.CurrentPrice)
      .Skip(skipItems)
      .Take(takeItems);

    var results = expression
      .ToList();

    return results;
  }

    public List<string> GetSimulators()
  {
      return _simulators.ToList();
  }

   private List<string> GetSeededSimulators()
    {
        return new List<string> {
                      Fsx, Fsxe,
                      P3dv1, P3dv2, P3dv2, P3dv3, P3dv4, P3dv5,
                      Msfs, Xp11, Afs2
        };
    }

  private static List<Product> GetSeededProducts()
  {
    var products = new List<Product> {
                new Product {
                    Id = 84,
                    Name = "05S Vernonia Municipal Airport",
                    Platform = "FSX & Prepar3D",
                    CurrentPrice = 29.95m,
                    Link = "https://orbxdirect.com/product/05s",
                    Simulators = new List<string>() {
                      Fsx, Fsxe,
                      P3dv1, P3dv2, P3dv2, P3dv3, P3dv4, P3dv5
                    }
                },
                new Product {
                    Id = 85,
                    Name = "0S9 Jefferson County International",
                    Platform = "FSX & Prepar3D",
                    CurrentPrice = 34.95m,
                    Link = "https://orbxdirect.com/product/0S9",
                    Simulators = new List<string> {
                      Fsx, Fsxe,
                      P3dv1, P3dv2, P3dv2, P3dv3, P3dv4, P3dv5
                    }
                },
                new Product {
                    Id = 86,
                    Name = "11S Sekiu Airport",
                    Platform = "FSX & Prepar3D",
                    CurrentPrice = 32.95m,
                    Link = "https://orbxdirect.com/product/11s",
                    Simulators = new List<string> {
                      Fsx, Fsxe,
                      P3dv1, P3dv2, P3dv2, P3dv3, P3dv4, P3dv5
                    }
                },
                new Product {
                    Id = 87,
                    Name = "1S2 Darrington Municipal Airport",
                    Platform = "FSX & Prepar3D",
                    CurrentPrice = 32.95m,
                    Link = "https://orbxdirect.com/product/1s2",
                    Simulators = new List<string> {
                      Fsx, Fsxe,
                      P3dv1, P3dv2, P3dv2, P3dv3, P3dv4, P3dv5
                    }
                },
                new Product {
                    Id = 433,
                    Name = "1S2 Darrington Municipal Airport",
                    Platform = "Microsoft Flight Simulator",
                    CurrentPrice = 16.99m,
                    Link = "https://orbxdirect.com/product/1s2-msfs",
                    Simulators = new List<string> {
                      Msfs
                    }
                },
                new Product {
                    Id = 280,
                    Name = "1S2 Darrington Municipal Airport",
                    Platform =  "X-Plane 11",
                    CurrentPrice = 32.95m,
                    Link = "https://orbxdirect.com/product/1s2-msfs",
                    Simulators = new List<string> {
                      Xp11
                    }
                },
                new Product {
                    Id = 88,
                    Name =  "1WA6 Fall City Airport",
                    Platform = "FSX & Prepar3D",
                    CurrentPrice = 32.95m,
                    Link = "https://orbxdirect.com/product/1wa6",
                    Simulators = new List<string> {
                      Fsx, Fsxe,
                      P3dv1, P3dv2, P3dv2, P3dv3, P3dv4, P3dv5
                    }
                },
                new Product {
                    Id = 218,
                    Name =  "2B2/6B6 Plum Island Airport & Minute Man Air Field",
                    Platform = "FSX & Prepar3D",
                    CurrentPrice = 26.95m,
                    Link = "https://orbxdirect.com/product/2b2-6b6",
                    Simulators = new List<string> {
                      Fsx, Fsxe,
                      P3dv1, P3dv2, P3dv2, P3dv3, P3dv4, P3dv5
                    }
                },
                new Product {
                    Id = 217,
                    Name = "2B2/6B6 Plum Island Airport & Minute Man Air Field",
                    Platform =  "X-Plane 11",
                    CurrentPrice = 26.95m,
                    Link = "https://orbxdirect.com/product/2b2-6b6-xp11",
                    Simulators = new List<string> {
                      Xp11
                    }
                },
                new Product {
                    Id = 145,
                    Name =  "2S1 Vashon Island Airport",
                    Platform = "FSX & Prepar3D",
                    CurrentPrice = 0m,
                    Link = "https://orbxdirect.com/product/2s1",
                    Simulators = new List<string> {
                      Fsx, Fsxe,
                      P3dv1, P3dv2, P3dv2, P3dv3, P3dv4, P3dv5
                    }
                },
                new Product {
                    Id = 89,
                    Name =  "2W3 Swanson Airport",
                    Platform = "FSX & Prepar3D",
                    CurrentPrice = 32.95m,
                    Link = "https://orbxdirect.com/product/2s1",
                    Simulators = new List<string> {
                      Fsx, Fsxe,
                      P3dv1, P3dv2, P3dv2, P3dv3, P3dv4, P3dv5
                    }
                },
                new Product {
                    Id = 288,
                    Name = "2W3 Swanson Airport",
                    Platform =  "X-Plane 11",
                    CurrentPrice = 32.95m,
                    Link = "https://orbxdirect.com/product/2w3-xp11",
                    Simulators = new List<string> {
                      Xp11
                    }
                },
                new Product {
                    Id = 89,
                    Name =  "2W3 Swanson Airport",
                    Platform = "FSX & Prepar3D",
                    CurrentPrice = 34.95m,
                    Link = "https://orbxdirect.com/product/2wa1",
                    Simulators = new List<string> {
                      Fsx, Fsxe,
                      P3dv1, P3dv2, P3dv2, P3dv3, P3dv4
                    }
                },
                new Product {
                    Id = 91,
                    Name =  "3W5 Concrete Municipal Airport",
                    Platform = "FSX & Prepar3D",
                    CurrentPrice = 34.95m,
                    Link = "https://orbxdirect.com/product/3w5",
                    Simulators = new List<string> {
                      Fsx, Fsxe,
                      P3dv1, P3dv2, P3dv2, P3dv3, P3dv4, P3dv5
                    }
                },
                new Product {
                    Id = 443,
                    Name = "3W5 Concrete Municipal Airport",
                    Platform = "Microsoft Flight Simulator",
                    CurrentPrice = 17.99m,
                    Link = "https://orbxdirect.com/product/3w5-msfs",
                    Simulators = new List<string> {
                      Msfs
                    }
                },
                new Product {
                    Id = 356,
                    Name = "61B Boulder City Municipal Airport",
                    Platform = "Prepar3D v4",
                    CurrentPrice = 34.95m,
                    Link = "https://orbxdirect.com/product/61b",
                    Simulators = new List<string> {
                      P3dv4, P3dv5
                    }
                },
                new Product {
                    Id = 92,
                    Name =  "65S Bonners Ferry Airport",
                    Platform = "FSX & Prepar3D",
                    CurrentPrice = 32.95m,
                    Link = "https://orbxdirect.com/product/65s",
                    Simulators = new List<string> {
                      Fsx, Fsxe,
                      P3dv1, P3dv2, P3dv2, P3dv3, P3dv4
                    }
                },
                new Product {
                    Id = 93,
                    Name =   "74S Anacortes Airport",
                    Platform = "FSX & Prepar3D",
                    CurrentPrice = 34.95m,
                    Link = "https://orbxdirect.com/product/74s",
                    Simulators = new List<string> {
                      Fsx, Fsxe,
                      P3dv1, P3dv2, P3dv2, P3dv3, P3dv4
                    }
                },
                new Product {
                    Id = 281,
                    Name = "74S Anacortes Airport",
                    Platform =  "X-Plane 11",
                    CurrentPrice = 34.95m,
                    Link =  "https://orbxdirect.com/product/74s-xp11",
                    Simulators = new List<string> {
                      Xp11
                    }
                },
                new Product {
                    Id = 94,
                    Name =  "77S Creswell (Hobby Field)",
                    Platform = "FSX & Prepar3D",
                    CurrentPrice = 34.95m,
                    Link = "https://orbxdirect.com/product/77s",
                    Simulators = new List<string> {
                      Fsx, Fsxe,
                      P3dv1, P3dv2, P3dv2, P3dv3, P3dv4, P3dv5
                    }
                },
                new Product {
                    Id = 95,
                    Name =  "7S3 Stark's Twin Oaks Airpark",
                    Platform = "FSX & Prepar3D",
                    CurrentPrice = 32.95m,
                    Link = "https://orbxdirect.com/product/7s3",
                    Simulators = new List<string> {
                      Fsx, Fsxe,
                      P3dv1, P3dv2, P3dv2, P3dv3, P3dv4, P3dv5
                    }
                },
                new Product {
                    Id = 305,
                    Name = "7S3 Stark's Twin Oaks Airpark",
                    Platform =  "X-Plane 11",
                    CurrentPrice = 32.95m,
                    Link =  "https://orbxdirect.com/product/7s3-xp11",
                    Simulators = new List<string> {
                      Xp11
                    }
                },
                new Product {
                    Id = 146,
                    Name =  "7WA3 West Wind Airport",
                    Platform = "FSX & Prepar3D",
                    CurrentPrice = 0,
                    Link = "https://orbxdirect.com/product/7wa3",
                    Simulators = new List<string> {
                      Fsx, Fsxe,
                      P3dv1, P3dv2, P3dv2, P3dv3, P3dv4, P3dv5
                    }
                },
                new Product {
                    Id = 139,
                    Name =  "AYEO Emo Mission",
                    Platform = "FSX & Prepar3D",
                    CurrentPrice = 0,
                    Link = "https://orbxdirect.com/product/ayeo",
                    Simulators = new List<string> {
                      Fsx, Fsxe,
                      P3dv1, P3dv2, P3dv2, P3dv3, P3dv4, P3dv5
                    }
                },
                new Product {
                    Id = 5,
                    Name =  "AYPY Jacksons International Airport",
                    Platform = "FSX & Prepar3D",
                    CurrentPrice = 39.95m,
                    Link = "https://orbxdirect.com/product/aypy",
                    Simulators = new List<string> {
                      Fsx, Fsxe,
                      P3dv1, P3dv2, P3dv2, P3dv3, P3dv4, P3dv5
                    }
                },
                new Product {
                    Id = 147,
                    Name =  "CAC8 Nanaimo Water Aerodrome",
                    Platform = "FSX & Prepar3D",
                    CurrentPrice = 0,
                    Link = "https://orbxdirect.com/product/cac8",
                    Simulators = new List<string> {
                      Fsx, Fsxe,
                      P3dv1, P3dv2, P3dv2, P3dv3, P3dv4
                    }
                },
                new Product {
                    Id = 269,
                    Name = "CAE3 Campbell River Water Aerodrome",
                    Platform = "Prepar3D v4",
                    CurrentPrice = 0,
                    Link = "https://orbxdirect.com/product/cae3",
                    Simulators = new List<string> {
                      P3dv3, P3dv4
                    }
                },
                new Product {
                    Id = 189,
                    Name = "CAG8 Pender Harbour Seaplane Base",
                    Platform = "FSX & Prepar3D",
                    CurrentPrice = 0,
                    Link = "https://orbxdirect.com/product/cag8",
                    Simulators = new List<string> {
                      Fsx, Fsxe,
                      P3dv1, P3dv2, P3dv2, P3dv3, P3dv4
                    }
                },
                new Product {
                    Id = 176,
                    Name = "CAX6 Ganges Water Aerodrome",
                    Platform = "FSX & Prepar3D",
                    CurrentPrice = 0,
                    Link = "https://orbxdirect.com/product/cax6",
                    Simulators = new List<string> {
                      Fsx, Fsxe,
                      P3dv1, P3dv2, P3dv2, P3dv3, P3dv4, P3dv5
                    }
                },
                new Product {
                    Id = 96,
                    Name =  "CEF4 Airdrie Airpark",
                    Platform = "FSX & Prepar3D",
                    CurrentPrice = 32.95m,
                    Link = "https://orbxdirect.com/product/cef4",
                    Simulators = new List<string> {
                      Fsx, Fsxe,
                      P3dv1, P3dv2, P3dv2, P3dv3, P3dv4, P3dv5
                    }
                },
            };

    return products;
  }

}