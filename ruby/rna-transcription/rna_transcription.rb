module Complement

  COMPLEMENT = {
    'C' => 'G',
    'G' => 'C',
    'T' => 'A',
    'A' => 'U'
  }

  def self.of_dna(rna)
    return rna.chars.sum('') {|c| COMPLEMENT[c]}
  end

end
