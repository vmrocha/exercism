module ResistorColor
    COLORS = ["black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"].freeze

    def self.color_code(color)
        COLORS.find_index(color)
    end
end

