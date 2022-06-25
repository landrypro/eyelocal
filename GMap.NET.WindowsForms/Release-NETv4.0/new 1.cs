this._adapter.DeleteCommand.CommandText = "DELETE FROM \"EyeLocalDB\".\"public\".\"Tracker\" WHERE ((\"IMEI\" = ?) AND ((? = 1 AND \"" +
                "SIM_No\" IS NULL) OR (\"SIM_No\" = ?)) AND ((? = 1 AND \"Carrier\" IS NULL) OR (\"Carr" +
                "ier\" = ?)) AND ((? = 1 AND \"Manufacturer\" IS NULL) OR (\"Manufacturer\" = ?)))";