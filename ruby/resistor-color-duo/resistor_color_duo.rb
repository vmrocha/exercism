class ResistorColorDuo

  BANDS = {
    black:  0,
    brown:  1,
    red:    2,
    orange: 3,
    yellow: 4,
    green:  5,
    blue:   6,
    violet: 7,
    grey:   8,
    white:  9
  }

  def self.value(bands)
    new(bands).to_i
  end

  private

    def initialize(bands)
      @bands = bands.take(2)
    end

  public

    attr_reader :bands

    def to_i
      bands.sum('') {|b| BANDS[b.to_sym].to_s }.to_i
    end

end
