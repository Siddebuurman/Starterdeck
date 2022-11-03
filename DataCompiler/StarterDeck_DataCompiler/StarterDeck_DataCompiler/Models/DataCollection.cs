using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StarterDeck_DataCompiler.Models
{
    public class DataCollection
    {
        public List<Engineer> engineers = new();
        public General general = new();
        public List<Scenario> scenarios = new();
        public List<Technique> techniques = new();


        public void Save(string path)
        {
            var serializer = new XmlSerializer(typeof(DataCollection));
            var writer = new StringWriter();
            serializer.Serialize(writer, this);

            File.WriteAllText(path, writer.ToString());
            
        }

        public void Load(string path)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(DataCollection));
                
                string xml = File.ReadAllText(path);

                DataCollection? container = null;
                try
                {
                    using StringReader reader = new(xml);
                    container = (DataCollection)serializer.Deserialize(reader);
                }
                catch (Exception e)
                {
                    if (e is InvalidOperationException invalid)
                        throw new Exception("File content is not supported by the serializer");
                    throw new Exception("Error deserializing data", e);
                }
                if (container is null)
                    throw new Exception("Deserialization process came up empty");

                engineers = container.engineers;
                general = container.general;
                scenarios = container.scenarios;
                techniques = container.techniques;

                foreach (Engineer e in engineers)
                {
                    if (!TypeData.engineerTypes.Contains(e.type))
                    {
                        TypeData.engineerTypes.Add(e.type);
                    }
                }
                foreach(Scenario s in scenarios)
                {
                }
                foreach(Technique t in techniques)
                {
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Data could not be loaded.\n\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
