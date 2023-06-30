using GISClient.Data.Model;
using GISClient.Pages;

namespace GISClient.Data.Service
{
    public class TestData
    {
        public List<GeoObjectDTO> GetGeoObjects()
        {
            List<GeoObjectDTO> geoObjects = new List<GeoObjectDTO>();
            GeoNamesFeatureDTO bldg = new GeoNamesFeatureDTO()
            {
                GeoNamesFeatureCode = "BLDG"
            };

            GeoObjectDTO area = new GeoObjectDTO()
            {
                Name = "Микрорайон",
                Geometry = new GeometryVersionDTO()
                {
                    BorderGeocodes = "[[60.00723625, 30.22990990], [60.00795076, 30.23026931], [60.00764991, 30.23266721], [60.00725505, 30.23251700], [60.00720402, 30.23272085], [60.00655128, 30.23240972], [60.00670976, 30.23088622], [60.00703479, 30.23092377]]"
                },
                GeoNameFeature = new GeoNamesFeatureDTO()
                {
                    GeoNamesFeatureCode = "DEVH"
                }
            };
            TopologyLinkDTO topologyLink1 = new TopologyLinkDTO() { Predicate = "212101212" };
            GeoObjectDTO geoObject1 = new GeoObjectDTO()
            {
                Name = "Объект 1",
                Geometry = new GeometryVersionDTO() { 
                    BorderGeocodes = "[[60.00715567, 30.23072529], [60.00725122, 30.23003404], [60.00790394, 30.23036663], [60.00787708, 30.23057584], [60.00733449, 30.23031299], [60.00727002, 30.23077969]]" 
                },
                GeoNameFeature = bldg,
                InputTopologyLinks = new List<TopologyLinkDTO>() {  topologyLink1 },
                OutputTopologyLinks = new List<TopologyLinkDTO>() { topologyLink1 }
            };
            GeoObjectDTO geoObject2 = new GeoObjectDTO()
            {
                Name = "Объект 2",
                Geometry = new GeometryVersionDTO()
                {
                    BorderGeocodes = "[[60.00787708, 30.23057584], [60.00762727, 30.23253922], [60.00717869, 30.23231928], [60.00720018, 30.23209397], [60.00754669, 30.23225491], [60.00776930, 30.23052354]]"
                },
                GeoNameFeature = bldg,
                InputTopologyLinks = new List<TopologyLinkDTO>() { topologyLink1 },
                OutputTopologyLinks = new List<TopologyLinkDTO>() { topologyLink1 }
            };
            GeoObjectDTO geoObject3 = new GeoObjectDTO()
            {
                Name = "Объект 3",
                Geometry = new GeometryVersionDTO()
                {
                    BorderGeocodes = "[[60.00719437, 30.23239377], [60.00716751, 30.23261371], [60.00661416, 30.23232939], [60.00677533, 30.23100975], [60.00688277, 30.23106339], [60.00674847, 30.23216310]]"
                },
                GeoNameFeature = bldg
            };
            geoObjects.Add(area);
            geoObjects.Add(geoObject1);
            geoObjects.Add(geoObject2);
            geoObjects.Add(geoObject3);
            return geoObjects;
        }
    }
}
